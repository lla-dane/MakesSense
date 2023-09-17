using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gravity : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform characterTransform;
    private bool isGravityReversed = false;
    public SpriteRenderer playerSprite;
    bool flipSpriteUnderAntiGravity = false;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        characterTransform = transform;
        playerSprite.flipX = flipSpriteUnderAntiGravity;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {

            playerSprite.flipX = !playerSprite.flipX;
            

            isGravityReversed = !isGravityReversed;

            rb.gravityScale = isGravityReversed ? -1.0f : 1.0f;

            characterTransform.Rotate(0, 0, -180.0f);
        }
    }
}