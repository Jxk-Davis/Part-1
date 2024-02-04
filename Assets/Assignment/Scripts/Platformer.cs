using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float maxSpe;
    public float jumpForce;
    public float walkForce;
    Vector2 direction;
    private bool grounded;
    private bool jumping;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb2d.velocity.magnitude < maxSpe)
        { rb2d.AddForce(direction * walkForce * Time.deltaTime); }
    }
    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
    }
}
