using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float currentTime = 0f;

    public void SaveBestTime()
    {
        
        float bestTime = PlayerPrefs.GetFloat("BestTime", 999f);

        
        if (currentTime < bestTime)
        {
            PlayerPrefs.SetFloat("BestTime", currentTime);
            PlayerPrefs.Save();
            Debug.Log("New best time saved: " + currentTime);
        }
    }

    public void ResetBestTime()
    {
        PlayerPrefs.DeleteKey("BestTime");
        PlayerPrefs.Save();
    }
}
