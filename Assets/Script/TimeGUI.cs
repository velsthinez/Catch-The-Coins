using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeGUI : MonoBehaviour
{
    public TMP_Text TimeUI;
    public GameObject TimePanel;

    private void OnEnable()
    {
        TimeManager.OnTime += UpdateTime;
        TimeManager.OnEnd += EndGame;
    }

    private void OnDisable()
    {
        TimeManager.OnTime -= UpdateTime;
        TimeManager.OnEnd -= EndGame;
    }

    public void UpdateTime(int currentTime)
    {
        TimeUI.text = currentTime.ToString();
    }

    public void EndGame()
    {
        if (TimePanel == null)
            return;
        
        TimePanel.SetActive(false);
    }
}
