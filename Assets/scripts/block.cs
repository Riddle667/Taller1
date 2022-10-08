using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] move newMove;
    [SerializeField] spawnerBlock spawn;
    public HudManager manager;
    public Rigidbody2D blockRigitbodi;
    bool canMove;
    AudioSource fall;

    private void Awake() {
        newMove = FindObjectOfType<move>();
        spawn = FindObjectOfType<spawnerBlock>();
        manager = FindObjectOfType<HudManager>();
        blockRigitbodi.gravityScale = 0f;
        canMove = true;

    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            canMove = false;
            blockRigitbodi.gravityScale = 1f;
            SoundManager.instance.PlaySound("fall");
        }
        
        if(canMove){
            this.blockRigitbodi.MovePosition(this.blockRigitbodi.position - newMove.returnVelocity()*Time.fixedDeltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        SoundManager.instance.PlaySound("success");
        if (other.gameObject.CompareTag("Floor")){
            Time.timeScale = 0f;
        }
        else{
            manager.scoreUp();
        }
    }


}
