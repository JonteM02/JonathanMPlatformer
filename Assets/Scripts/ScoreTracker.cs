using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = string.Format("Score; {0}", totalScore);
    }
}
