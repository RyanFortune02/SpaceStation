using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int GameScore = 0;
    public Text GameScoreText;

    public void IncrementGameScore()
    {
        GameScore += 50;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        GameScoreText.text = "Score: " + GameScore;
    }


    //Load next scene by name
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
        //Initialize Score and score text
    void Start()
    {
        UpdateScoreDisplay();
    }
}
