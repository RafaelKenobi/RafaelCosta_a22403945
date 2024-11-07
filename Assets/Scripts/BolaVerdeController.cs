using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BolaVerdeController : MonoBehaviour
{
    public float velocidade = 50f;
    Vector2 direction;
    ScoreScript scoreScript;
    [SerializeField] GameObject red2;
    [SerializeField] GameObject red1;

    int spawn;  

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = direction * velocidade;
    }


    private void Update()
    {
        scoreScript = GameObject.Find("Canvas").GetComponent<ScoreScript>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerScript playerScript = collision.gameObject.GetComponent<PlayerScript>();
        if (playerScript != null) 
        {
            rb.position = new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f));
            direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            rb.velocity = direction * velocidade;
            scoreScript.incrementScore();
 
            spawn = Random.Range(0, 2);
            if (spawn == 1)
            {
            GameObject redball2 = Instantiate(red2);
            }
            else
            {
            GameObject redball1 = Instantiate(red1);
            }

        }

    }
}