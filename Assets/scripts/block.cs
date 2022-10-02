using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] move newMove;
    [SerializeField] spawnerBlock spawn;
    public Rigidbody2D blockRigitbodi;
    bool canMove;

    private void Awake() {
        newMove = FindObjectOfType<move>();
        spawn = FindObjectOfType<spawnerBlock>();
        blockRigitbodi.gravityScale = 0f;
        canMove = true;

    }

    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.Space)){
            canMove = false;
            blockRigitbodi.gravityScale = 1f;
        }
        
        if(canMove){
            this.blockRigitbodi.MovePosition(this.blockRigitbodi.position - newMove.returnVelocity()*Time.fixedDeltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }
}
