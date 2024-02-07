using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public float spe;

    // Start is called before the first frame update
    void Start()
    {
        //get transform components of point A and point B
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,spe * Time.deltaTime,0); //move up by spe over time
        
        if (gameObject.transform.position.y >= pointA.transform.position.y) //check if we are higher than A. if so...
        { 
            spe *= -1; //reverse speed
        }

        if (gameObject.transform.position.y <= pointB.transform.position.y) //check if we are lower than A. if so...
        {
            spe *= -1; //reverse speed
        }
    }
}
