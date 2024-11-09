using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public TextMeshProUGUI score;


    private void Start()
    {
        int highscore = (PlayerPrefs.GetInt("highscore",0));
        score.text = score.text + highscore;
        //(PlayerPrefs.GetInt("highscore"), 0).ToString();
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }


}
