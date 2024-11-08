using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaVermelhaController : MonoBehaviour
{
    public float velocidade = 50f;
    Vector2 direction;
    public Rigidbody2D redBall;
    PassageScript passage;

    public void Start()
    {
        ballInit();
        passage = GameObject.Find("passage").GetComponent<PassageScript>();
    }

    public virtual void ballInit()
    {
        redBall = GetComponent<Rigidbody2D>();
        React();
        
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        redBall.velocity = direction * velocidade;
        redBall.position = new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f));
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Parede"))
        {
            React();
        }

        PlayerScript playerScript = collision.gameObject.GetComponent<PlayerScript>();
        if (playerScript != null)
        {
            Time.timeScale = 0f;
            passage.mudaCena2();
            SceneManager.LoadScene("EndScene");

        }
    }
    public virtual void React()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        redBall.velocity = direction * velocidade;
    }
}
