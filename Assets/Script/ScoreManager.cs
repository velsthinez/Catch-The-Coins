using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public delegate void OnScoreUpdate(int score);

    public static OnScoreUpdate OnScore;
    
    public int CurrentScore = 0;

    public ScoreGUI ScoreGUI;

    private void OnEnable()
    {
        Coin.onCoinCollected += CoinsCollected;
    }

    private void OnDisable()
    {
        Coin.onCoinCollected -= CoinsCollected;
    }
    
    // Start is called before the first frame update
    void CoinsCollected()
    {
        CurrentScore += 10;
        
        OnScore.Invoke(CurrentScore);
        // ScoreGUI.UpdateScore(CurrentScore);
    }

}
