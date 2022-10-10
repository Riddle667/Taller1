using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] Crane newMove;
    [SerializeField] spawnerBlock spawn;
    public Rigidbody2D blockRigitbodi;
    bool canMove;
    bool gameOver = false;
    bool ignoreCollision = false;

    private void Awake() {
        newMove = FindObjectOfType<Crane>();
        spawn = FindObjectOfType<spawnerBlock>();
        blockRigitbodi.gravityScale = 0f;
        canMove = true;
        GameplayController.instance.CurrentBlock = this;

    }

    private void Update() {
        moveBlock();
    }

    public void dropBlock(){
        
        canMove = false;
        blockRigitbodi.gravityScale = 1f;
        AudioManager.instance.PlaySound("fall");
    }
    void moveBlock(){
        if(canMove){
            this.blockRigitbodi.MovePosition(this.blockRigitbodi.position - newMove.returnVelocity()*Time.fixedDeltaTime);
        }
    }

    void landed(){
        if(gameOver){
            return;
        }

        GameplayController.instance.SpawnNewBlock();
        GameplayController.instance.moveCamera();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (ignoreCollision){
            return;
        }

        AudioManager.instance.PlaySound("success");
        if (other.gameObject.CompareTag("Floor")){
            Time.timeScale = 0f;
            gameOver = true;
        }
        else{
            HudManager.instance.scoreUp();
            Invoke("landed",2f);
            ignoreCollision = true;
        }
    }

}
