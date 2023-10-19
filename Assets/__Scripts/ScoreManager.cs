using System.Collections;
using System.Collections.Generic;
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
        scoreText.text = score.ToString()+"Score: ";
        highscoreText.text = "High Score: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 100;
        scoreText.text = score.ToString() + "Score: ";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
