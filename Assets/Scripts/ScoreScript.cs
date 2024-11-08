using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject timerTag;
    PassageScript passage;

    public int score = 0;
    public float tempo = 30f;

    private void Start()
    {
        tempo = 30f;
        score = 0;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
        passage = GameObject.Find("passage").GetComponent<PassageScript>();
    }

    public void incrementScore()
    {
        score += 1;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
    }

    private void Update()
    {
        tempo -= Time.deltaTime;
        int timer = (int)tempo;
        timerTag.GetComponent<TMPro.TextMeshProUGUI>().text = "Time Left " + timer;
        if (tempo <= 0) 
        {
            mudarcena();
        }
    }
    public void mudarcena()
    {
        SceneManager.LoadScene("GameScene2");
        passage.mudaCena1();
    }
}
