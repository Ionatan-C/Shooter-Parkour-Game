using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;

    private int scoreINT = 0;
    public static int LastScore;
    public void addScore(int newScore)
    {
        scoreINT += newScore;
    }
    void Update()
    {
        ScoreText.text = "Score 0" + scoreINT;
        LastScore = scoreINT;
    }
}
