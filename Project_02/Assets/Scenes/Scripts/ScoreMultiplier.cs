using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMultiplier : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Text scoreText;
    private int scoreValue;

    private bool doubleScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

        doubleScore = false;
    }

    // Update is called once per frame


    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y < 0)
            Destroy(this.gameObject);
    }

    private bool OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            doubleScore = true;
            GameObject.Destroy(this.gameObject);
            int multiplyScore = scoreText.GetComponent<ScoreController>().score * 2;
            scoreText.GetComponent<ScoreController>().UpdateScore();
        }

        return false;
    }
}