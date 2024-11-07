using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject text;

    public int score = 0;

    private void Start()
    {
        score = 0;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
    }

    public void incrementScore()
    {
        score += 1;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
    }
}
