using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBestScore : MonoBehaviour
{
    public TMP_Text bestTimeText;  // Reference to the Text UI element

    void Start()
    {
        // Get the best time from PlayerPrefs
        float bestTime = PlayerPrefs.GetFloat("BestTime", 999f);  // Default to a large number if no best time is set

        // If no best time has been set, display a message like "No Best Time Yet"
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
