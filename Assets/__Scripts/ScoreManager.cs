
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString()+"  Points";
        highscoreText.text = "HighScore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = score.ToString() + "  Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
   
        
    }
}
