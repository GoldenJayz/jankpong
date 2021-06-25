using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5000f;
    public int score;
    public Text scoretext;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(transform.up * speed * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(-transform.up * speed * Time.deltaTime);
        }
    }
    /*
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("border"))
        {
            return;
        }
        else
        {
            AddScore();
            scoretext.text = score.ToString();
        }
    }
    void AddScore()
    {
        score++;
    }
    */
}