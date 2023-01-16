using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public delegate void OnScoreUpdate(int score);

    public static OnScoreUpdate OnScore;
    
    public delegate void OnFinalScore(int score);

    public static OnFinalScore OnFinal;        
        
        
    public int CurrentScore = 0;
    
    
    private void OnEnable()
    {
        Coin.onCoinCollected += CoinsCollected;
        TimeManager.OnEnd += FinalScore;
    }

    private void OnDisable()
    {
        Coin.onCoinCollected -= CoinsCollected;
        TimeManager.OnEnd -= FinalScore;
    }
    
    // Start is called before the first frame update
    void CoinsCollected(int amount)
    {
        CurrentScore += amount;
        
        OnScore.Invoke(CurrentScore);
        // ScoreGUI.UpdateScore(CurrentScore);
    }

    void FinalScore()
    {
        OnFinal.Invoke(CurrentScore);
        Debug.Log("final score is " +  CurrentScore);
    }

}
