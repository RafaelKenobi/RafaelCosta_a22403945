using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float velocidade = 5f;
    public Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movimento = new Vector2(horizontal, vertical);

        player.velocity = movimento * velocidade;
    }
} 