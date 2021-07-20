using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Is The Same Has PlayerCTRL.cs But This Is For TopDown View Games
public class PlayerCTRL : MonoBehaviour
{
    public float speed; // Movement Speed 
    private Rigidbody2D rb; // Taking RigidBody2D Component
    private float moveInputHor; // This Is Can't Fit In An Comment
    private float moveInputVer; // Bruh
    private Vector2 moveVelo; // Same Case Of moveInputHor

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();// Talking The Rigidbdy Comp From The Player 
    }

     void Update()
    {
        moveInputHor = Input.GetAxis("Horizontal");
        moveInputVer = Input.GetAxis("Vertical");
        Vector2 moveInput = new Vector2(moveInputHor, moveInputVer);
        moveVelo = moveInput.normalized * speed;
    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelo * Time.deltaTime);// Adding Force
    }
}
