using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scoreboard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("ball"))
        {
            other.gameObject.transform.position = new Vector2(0, 0);
        }
    }
}
