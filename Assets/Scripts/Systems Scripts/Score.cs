using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float currentScore;

    public void Start()
    {
        currentScore = 0;
        score.SetText("SCORE: " + currentScore);
    }

    public void Update()
    {
        score.SetText("SCORE: " + currentScore);
    }
}
