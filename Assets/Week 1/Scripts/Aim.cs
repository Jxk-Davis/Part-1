using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float spe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dir = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, dir * spe * Time.deltaTime);
    }
}
