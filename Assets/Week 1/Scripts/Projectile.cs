using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float spe;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 dir = new Vector2(spe * Time.deltaTime, 0);
        rb2d.MovePosition(rb2d.position + dir);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
        //transform.Translate(spe * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject + ": Hit!");
        Destroy(gameObject);
    }
}
