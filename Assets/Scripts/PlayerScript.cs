using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float velocidade = 5f;
    public Rigidbody2D player;
    private Animator animator;
    bool isDead;
    bool isRuning;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movimento = new Vector2(horizontal, vertical);
        player.velocity = movimento * velocidade;
        animator.SetBool("isRuning", true);
    }
}