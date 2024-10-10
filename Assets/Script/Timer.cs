using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TMP_Text timerText;
    static float timePassedInSeconds;
    private bool isTimerRunning = true;

    private void Start()
    {
        timerText = GetComponent<TMP_Text>();
    }
    void Update()
    {
        if (isTimerRunning)
        {
            timePassedInSeconds += Time.deltaTime;
            timerText.text = $"Timer: {(int)timePassedInSeconds}";
        }
    }
    public void StopTimer()
    {
        isTimerRunning = false;
    }
}
