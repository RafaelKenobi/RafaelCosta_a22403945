using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject timerTag;
    PassageScript passage;

    public int score = 0;
    public float tempo = 30f;
    public float tempo2 = 30f;

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
            tempo = 30f;

        }
    }
    public void mudarcena()
    {
        passage.mudaCena1();
        SceneManager.LoadScene("GameScene2");
        tempo2 -= Time.deltaTime;
        if (tempo2 <= 0)
        {
            mudarcena2();
        }

    }
    public void mudarcena2()
    {

        passage.mudaCena2();
        SceneManager.LoadScene("EndScene");

    }
}
