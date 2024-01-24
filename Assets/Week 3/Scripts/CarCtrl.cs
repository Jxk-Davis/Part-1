using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCtrl : MonoBehaviour
{
    Rigidbody2D rb2d;
    float accel;
    float steer; //input values
    public float forwSpe = 300;
    public float steerSpe = 40;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accel = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb2d.AddTorque(steer * -steerSpe * Time.deltaTime);
        Vector2 force = transform.up * accel * forwSpe * Time.deltaTime;
        rb2d.AddForce(force);
    }
}
