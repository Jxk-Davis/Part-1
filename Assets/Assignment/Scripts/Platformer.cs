using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float maxSpe;
    public float jumpForce;
    private Vector3 jumpTeleport;
    public float accel;
    Vector2 direction;
    public bool grounded;
    public bool jumping;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }
    // Update is called once per frame
    void Update()
    {
        Jump();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }
        direction.x = Input.GetAxis("Horizontal");
    }

    private void Jump()
    { 
        if(grounded == true)// check if we are grounded. if so...
        {
            if (jumping == true) //check if space is pressed. if so...
            {
                rb2d.AddForce(Vector2.up * jumpForce); // get pushed up by jumpForce
                grounded = false;// set grounded to false
                jumping = false; //set jumping to false
            }
        }
    }

    private void Move()
    {
        if(grounded == true) //check if we are on the ground. if so...
        {
            if (rb2d.velocity.magnitude < maxSpe) // check that we are under the speed limit. if so...
            { rb2d.AddForce(direction * accel * Time.deltaTime); } // accelerate in the direction of Horizontal axis
        } else //otherwise...
        { rb2d.AddForce(direction * (accel/2) * Time.deltaTime); }// accelerate in the direction of Horizontal axis
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
}
