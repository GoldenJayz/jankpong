using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomborder : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 250f;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
        }
    }
}
