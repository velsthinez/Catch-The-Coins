using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreGUI : MonoBehaviour
{
    public TMP_Text ScoreUI;
    public TMP_Text FinalScoreUI;
    public GameObject FinalScorePanel;
    public GameObject ScorePanel;

    private void OnEnable()
    {
        ScoreManager.OnScore += UpdateScore;
        ScoreManager.OnFinal += ShowFinalScore;
    }

    private void OnDisable()
    {
        ScoreManager.OnScore -= UpdateScore;
        ScoreManager.OnFinal -= ShowFinalScore;
        
    }

    public void UpdateScore(int currentScore)
    {
        ScoreUI.text = currentScore.ToString();
    }

    public void ShowFinalScore(int finalScore)
    {
        if (FinalScorePanel == null || FinalScoreUI == null || ScorePanel == null)
            return;
        
        ScorePanel.SetActive(false);
        FinalScorePanel.SetActive(true);
        FinalScoreUI.text = finalScore.ToString();
    }
    
}
