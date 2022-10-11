using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crane : MonoBehaviour
{
    Vector2 velocity = new Vector2 (2f,0f);
    public Rigidbody2D gruaRigidBody2d;
    public static Crane instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void VelocityBoost()
    {
        velocity *= 1.5f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        this.gruaRigidBody2d.MovePosition(this.gruaRigidBody2d.position - velocity*Time.fixedDeltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Wall"))
        {
            
            this.velocity *= -1;
        }
    }

    public Vector2 returnVelocity(){
        return velocity;
    }
}
