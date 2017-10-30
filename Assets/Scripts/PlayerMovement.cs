using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    #region Editor Fields
    [SerializeField]
    private float acceleration = 8;

    [SerializeField]
    private float jumpHeight = 6;

    [SerializeField]
    private Transform groundCheckPosition;

    [SerializeField]
    private float groundCheckRadius = 0.07f;

    [SerializeField]
    private LayerMask whatIsGround;

    [SerializeField]
    private float maxSpeed = 10;
    #endregion

    #region private fields
    private bool isOnGround;

    private Rigidbody2D myRigidbody2D;

    private float horizontalInput;

    private bool pressedJump;
    #endregion


    private void UpdateIsOnGround()
    {
        Collider2D[] groundColliders = Physics2D.OverlapCircleAll
            (groundCheckPosition.position, groundCheckRadius, whatIsGround);

        isOnGround = groundColliders.Length > 0;

    }

    // Use this for initialization
    void Start ()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();  
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetMovementInput();
        GetJumpInput();

        UpdateIsOnGround();

    }

    private void GetJumpInput()
    {
        pressedJump = Input.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        HandlePlayerMovement();
        HandleJump();
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            myRigidbody2D.velocity =
                new Vector2(myRigidbody2D.velocity.x, jumpHeight);

            isOnGround = false;
        }
    }

    private void GetMovementInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void HandlePlayerMovement()
    {
        //myRigidbody2D.velocity =
        //    new Vector2(speed * horizontalInput, myRigidbody2D.velocity.y);
        Vector2 forceToAdd = new Vector2(acceleration * horizontalInput, 0);
        if(Math.Abs(myRigidbody2D.velocity.x) < maxSpeed)
        {
            myRigidbody2D.AddForce(forceToAdd);
        }
    }
}
