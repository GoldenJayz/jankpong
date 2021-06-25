using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5000f;
    public float up = 1;
    public int score;
    public Text scoretext2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.up * speed * Time.deltaTime);
        }
    }
    /*
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("border"))
        {
            return;
        }
        else
        {
            AddScore();
            scoretext2.text = score.ToString();
        }
    }

    void AddScore()
    {
        score++;
    }
    */
}
