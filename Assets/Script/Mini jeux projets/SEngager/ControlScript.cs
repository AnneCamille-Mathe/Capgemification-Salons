using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ControlScript : MonoBehaviour
{
    //Variables
    private float dirX;
    public float moveSpeed = 4f, jumpForce = 400f;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //On récupère le rigidBody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //On récupère la direction horizontal
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        //Si le bouton saut est pressé on lance notre fonction correspondante
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            DoJump();
        }
    }

    //On déplace le joueur
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX*moveSpeed, rb.velocity.y);
    }

    //On fait sauter notre joueur
    public void DoJump()
    {
        if (rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
        }
    }
}
