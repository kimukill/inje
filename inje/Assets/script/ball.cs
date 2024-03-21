using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{   
    public float input;
    private Rigidbody2D rb;
    public float jumpForce = 3.0f;
    public float moveSpeed = 5.0f;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        input = Input.GetAxis("Horizontal");
    }
    void FixedUpdate(){
        Vector2 moveDirection = new Vector2(input*moveSpeed, rb.velocity.y);
        rb.velocity=moveDirection;
    }
    void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.CompareTag("Ground")){
        jump();
        }
        if(collision.gameObject.CompareTag("SuperGround")){
            superjump();
        }
    }
    void jump(){
        rb.velocity = Vector2.up*jumpForce;
    }
    void superjump(){
        rb.velocity = Vector2.up*jumpForce*1.3f;
    }
}
