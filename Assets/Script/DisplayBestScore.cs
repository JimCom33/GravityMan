using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


// Used CHATGPT

public class DisplayBestScore : MonoBehaviour
{
    public TMP_Text bestTimeText;

    void Start()
    {
       
        float bestTime = PlayerPrefs.GetFloat("BestTime", 999f);

        
        if (bestTime == 999f)
        {
            bestTimeText.text = "Best Time: Not Set";
        }
        else
        {
            // Display the best time formatted as minutes and seconds
            int minutes = Mathf.FloorToInt(bestTime / 60F);
            int seconds = Mathf.FloorToInt(bestTime % 60F);
            bestTimeText.text = string.Format("Best Time: {0:00}:{1:00}", minutes, seconds);
        }
    }
}
