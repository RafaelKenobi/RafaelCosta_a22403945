using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EndScene : MonoBehaviour
{
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        if (ScoreScript.Instance.score > PlayerPrefs.GetInt("highscore"))
        {

            PlayerPrefs.SetInt("highscore", ScoreScript.Instance.score);
            PlayerPrefs.Save();
            score.text = "NEW HIGHSCORE: " + ScoreScript.Instance.score;
        }
        else
        {

            score.text = "SCORE: " + ScoreScript.Instance.score + "\nHIGHSCORE: " + PlayerPrefs.GetInt("highscore");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
