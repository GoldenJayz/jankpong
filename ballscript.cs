using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 75f;
    public int score;
    public int score2;
    public Text scoretext2;
    public Text scoretext;
    // Start is called before the first frame update

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 0) * 25f);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("player2"))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 5) * force, ForceMode2D.Force);
            //new Vector2(-10, 5) * force, ForceMode2D.Force
            if(other.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 5) * force, ForceMode2D.Force);
            }
            else if(other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, -5) * force, ForceMode2D.Force);
            }
        }
        else if(other.gameObject.CompareTag("player1"))
        {
            if (other.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 5) * force, ForceMode2D.Force);
            }
            else if (other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(10, -5) * force, ForceMode2D.Force);
            }
        }
        else if(other.gameObject.CompareTag("rightborder"))
        {
            AddScore1();
            if(score < 10)
            {
                scoretext.text = score.ToString();
            }
            else if(score >= 10)
            {
                SceneManager.LoadScene("menu");
            }
        }
        else if(other.gameObject.CompareTag("leftborder"))
        {
            AddScore2();
            if(score2 < 10)
            {
                scoretext2.text = score2.ToString();
            }
            else if(score2 >= 10)
            {
                SceneManager.LoadScene("menu");
            }
        }
    }
    // Update is called once per frame
    // This checks if the r key is pressed and if it is it will reset the position of the ball
    void Update()
    {
        if(transform.position.x == 0 && transform.position.y == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 0) * 10f);
        }
        if (Input.GetKey("r"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = new Vector2(0, 0);      
        }
    }

    //everything below computers the score

    void AddScore1()
    {
        score++;
    }

    void AddScore2()
    {
        score2++;
    }

    public Vector2 randomvector()
    {
        float randomvect = Random.Range(10, 50);
        return new Vector2(Mathf.Cos(randomvect), Mathf.Sin(randomvect));
    }
}