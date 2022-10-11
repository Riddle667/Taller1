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

    [HideInInspector]
    public GameObject panelGameOver;

    private void Awake() {

        
        panelGameOver = HudManager.instance.panelGameOver;
        newMove = FindObjectOfType<Crane>();
        spawn = FindObjectOfType<spawnerBlock>();
        blockRigitbodi.gravityScale = 0f;
        canMove = true;
        GameplayController.instance.CurrentBlock = this;
        

    }

    void Start()
    {
        panelGameOver.SetActive(false);
    }


    //movimiento del bloque
    private void Update() {
        moveBlock();
    }

    //cuando cae el bloque
    public void dropBlock(){
        
        canMove = false;
        blockRigitbodi.gravityScale = 1f;
        AudioManager.instance.PlaySound("fall");
    }

    //para que siga el movieminteo horizontal
    void moveBlock(){
        if(canMove){
            this.blockRigitbodi.MovePosition(this.blockRigitbodi.position - newMove.returnVelocity()*Time.fixedDeltaTime);
        }
    }

    //Para hacer que aparezca un nuevo bloque y suba la camara
    void landed(){
        if(gameOver){
            return;
        }

        GameplayController.instance.SpawnNewBlock();
        GameplayController.instance.moveCamera();
    }

    //para que el bloque detecte si cayó correctamente en otro bloque o en el piso
    private void OnCollisionEnter2D(Collision2D other) {
        if (ignoreCollision){
            return;
        }

        AudioManager.instance.PlaySound("success");
        if (other.gameObject.CompareTag("Floor")){
            Time.timeScale = 0f;
            panelGameOver.SetActive(true);
        }
        else{
            HudManager.instance.scoreUp();
            Invoke("landed",2f);
            ignoreCollision = true;
            Crane.instance.VelocityBoost();
        }
    }

}
