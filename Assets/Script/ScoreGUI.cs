using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreGUI : MonoBehaviour
{
    public TMP_Text ScoreUI;

    private void OnEnable()
    {
        ScoreManager.OnScore += UpdateScore;
    }

    private void OnDisable()
    {
        ScoreManager.OnScore -= UpdateScore;
        
    }

    public void UpdateScore(int currentScore)
    {
        ScoreUI.text = currentScore.ToString();
    }
}
