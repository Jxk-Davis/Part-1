using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer sprRend;

    // Start is called before the first frame update
    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
        sprRend.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject + ": what's happening " + collision.gameObject + ", eh?");
        sprRend.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(gameObject + ": later, " + collision.gameObject);
        sprRend.color = Color.yellow;
    }
}
