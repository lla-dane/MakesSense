using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 8f;
    
    

    Vector2 moveInput;
    
    public bool IsAlive = true;

    Animator myAnimator;
    
    Rigidbody2D rb;
    void Start()
    {
        Debug.Log("Started");
        
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
       

    }


    void Update()
    {
        if (IsAlive)
        {
            Run();
            FlipSprite();
            
        }

    }

    void OnMove(InputValue value)
    {
        
        moveInput = value.Get<Vector2>();
    }

    

        void Run()
        {

            
            Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, rb.velocity.y);
            rb.velocity = playerVelocity;

            bool playerHasHorizontalSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

            myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
        }

        void FlipSprite()
        {
            bool playerHasHorizontalSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

            if (playerHasHorizontalSpeed)
            {
                transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x), 1f);

            }

        }

    public void FlipSpriteUnderReverseGravity()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(-rb.velocity.x), 1f);

        }

    }
}
