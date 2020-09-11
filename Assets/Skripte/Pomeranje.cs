using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Pomeranje : MonoBehaviour
{
   private Rigidbody2D rb;
    private bool face = true;
    private Vector3 localScale;
    public int ground=0;
 
    float horizontalMove=0f;
public Animator animator;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        localScale = transform.localScale;
     
    }

    private void Update()
    {  
        horizontalMove=Input.GetAxisRaw("Horizontal")*10f;
        animator.SetFloat("Trcanje", Mathf.Abs(horizontalMove));

   
    
     if (Input.GetKeyDown("space")  && ground < 2){
            
                  Jump(); 
               
     }
            if (Mathf.Abs(horizontalMove) > 0 && rb.velocity.y == 0){
              
                animator.SetFloat("Trcanje", 1);
              }
            else{
                animator.SetFloat("Trcanje", 0);
                
                
              }
            if (rb.velocity.y == 0)
            {
                animator.SetBool("skakanje",false);
                 ground=0;
            }
            if (rb.velocity.y > 0)
            {
                animator.SetBool("skakanje", true);
              
            }
            if (rb.velocity.y < 0)
            {
                animator.SetBool("skakanje", false);
               
            }  
    }

      private void Jump()
  {
    ground++; 
    rb.velocity = Vector2.up * 6f;
           
  }
    private  void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
        Flip();
    }
    private void Flip()
    {
        if (horizontalMove > 0)
            face = true;
        else if(horizontalMove<0)
            face = false;
        if (((face) && (localScale.x < 0)) || ((!face) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

}
