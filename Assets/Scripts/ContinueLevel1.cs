using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContinueLevel1 : MonoBehaviour
{
    public Text ScoreText;

    void Update()
    {
        ScoreText.text = "Score 0" + Score.LastScore;
    }
}
