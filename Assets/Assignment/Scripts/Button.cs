using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject gem;
    public GameObject gemSpawn;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(gem, gemSpawn.transform.position, Quaternion.identity); // spawn a gem at the spawn location
    }
}
