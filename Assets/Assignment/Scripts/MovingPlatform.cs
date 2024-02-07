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
        //move up/down by spe
        //check each frame if y transform equals or exceeds that of Point A or Point B, if so multiply spe by -1
    }
}
