using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject gem;
    public GameObject gemSpawn;
    SpriteRenderer sprRend;
    public bool pressed;
    // Start is called before the first frame update
    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
        sprRend.color = Color.green;
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(pressed == false)
        {
            Instantiate(gem, gemSpawn.transform.position, Quaternion.identity);
            sprRend.color = Color.red;
            pressed = true;
        }
    }
}
