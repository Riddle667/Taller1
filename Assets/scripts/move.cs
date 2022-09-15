using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector2 velocity = new Vector2 (2f,0f);
    public Rigidbody2D gruaRigidBody2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        this.gruaRigidBody2d.MovePosition(this.gruaRigidBody2d.position - velocity*Time.fixedDeltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Wall")){
            this.velocity *= -1;
        }
    }
}