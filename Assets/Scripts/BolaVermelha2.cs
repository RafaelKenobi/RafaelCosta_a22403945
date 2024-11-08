using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

}