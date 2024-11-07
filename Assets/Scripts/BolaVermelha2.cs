using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class BolaVermelha2 : BolaVermelhaController
{

    public GameObject player;

    public override void ballInit()
    { 
        player = GameObject.FindWithTag("Player");

        base.ballInit();
    }

    public override void React()
    {

        Vector2 directionToPlayer = (player.transform.position - transform.position).normalized;

        redBall.velocity = directionToPlayer * velocidade;
    }

    public new void OnCollisionEnter2D(Collision2D collision)
    {
        // verifica bater com a parede
        if (collision.gameObject.CompareTag("Parede"))
        {
            React();
        }
        PlayerScript playerScript = collision.gameObject.GetComponent<PlayerScript>();
        if (playerScript != null)
        {
            Time.timeScale = 0f;
            // SceneManager.LoadScene("Finish"); //mais tarde fazer uma cena de final de jogo
        }
    }

}

/*

        if(
        /*PlayerScript playerScript = Position.gameObject.GetComponent<PlayerScript>();
        player = GameObject.Find("player");
        Vector2 direction;
        direction = new Vector2( distancia - origem ).normalized;*/
