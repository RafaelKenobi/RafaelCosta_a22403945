using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject highScoreText;
    [SerializeField] GameObject timerTag;
    [SerializeField] GameObject powerup;
    PassageScript passage;

    public int score = 0;
    public float tempo = 30f;
    public float tempo2 = 30f;
    public float tempopower = 10f;
    public int highScore;

    private void Start()
    {
        tempo = 30f;
        score = 0;
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
        passage = GameObject.Find("passage").GetComponent<PassageScript>();
        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = (PlayerPrefs.GetInt("highscore"), 0).ToString();
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

        hellopower();

        if (SceneManager.GetActiveScene().name == "GameScene2")
        {
            tempo2 -= Time.deltaTime;
            if (tempo2 <= 0)
            {
                mudarcena2();
            }
        }
    }

    public void hellopower()
    {
        tempopower -= Time.deltaTime;
        if (tempopower <= 0)
        {
            GameObject obj = Instantiate(powerup);
            obj.transform.position = new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f));
            tempopower = 40f;
        }
    }

    public void mudarcena()
    {
        passage.mudaCena1();
        SceneManager.LoadScene("GameScene2");
    }

    public void mudarcena2()
    {
        passage.mudaCena2();
        SceneManager.LoadScene("EndScene");

    }
}
