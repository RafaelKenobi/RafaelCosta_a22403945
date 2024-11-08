using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] GameObject highScoreText;

    private void Start()
    {
        highScoreText.text = (PlayerPrefs.GetInt("highscore"), 0).ToString();
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
