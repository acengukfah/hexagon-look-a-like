using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static int highScore = 0;
    private static int waves = 0;

    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        waves = 0;
        highScore = PlayerPrefs.GetInt("highscore");
        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        waves = PlayerPrefs.GetInt("score");
        scoreText.text = waves.ToString();
        if (waves >= highScore)
        {
            PlayerPrefs.SetInt("highscore", waves);
            highScoreText.text = waves.ToString();
        }
    }
}
