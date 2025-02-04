using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rb2d;
    public float force;

    private void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.AddForce(direction * force * Time.deltaTime);
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject + ": I've been hit by, I've been struck by: a " + collision.gameObject);
    }
}
