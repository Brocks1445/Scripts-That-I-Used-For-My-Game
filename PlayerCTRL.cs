using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTRL : MonoBehaviour
{
    // Public VARs
    public float speed; // Speed Of Movement
    public float jumpForce;// Force Of Jump
    public int ejumpvalue; // Number Of Jumps
    public Transform groundCheck; // Used To Check If Player Is In The Ground
    public float checkRadius; // Radius To Check Ground Check
    public LayerMask whatisGrounded; // Ground Layer
    // Private VARs
    private float moveInput; // If The Player Prees 'a' or '<=' The X Axis Is "-1" else Player Prees The Oposite The X Axis Is "1"
    private Rigidbody2D rb; // The Rigidbody2D Comp
    private bool isGrounded; // Basicly The GroundCheck But In Boolien 
    private int eJump; // eJumpValue But Private
    
    // Starts At The Start Of The Game
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Getting The Rigidbody2D Compnent
        eJump = ejumpvalue; // Number Of Jumps
    }

    // Update is called once per frame *And Fixed*
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGrounded);

        moveInput = Input.GetAxisRaw("Horizontal"); // Getting The Input Of The Player
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); // Adding Force Based On moveInput
    }


    // Sane As FixedUpdate But Normal Insted Of Fixed
    void Update()
    {
        if (isGrounded == true) // Checking If The Player Is Grounded
        {
            eJump = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && eJump > 0) // Adding Jump
        {


            rb.velocity = Vector2.up * jumpForce;
            eJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && eJump == 0 && isGrounded == true) // Same Us Adding Jump But But, I Don't Know 
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        // Thanks To BlackThronPord *:)*


    }
}
