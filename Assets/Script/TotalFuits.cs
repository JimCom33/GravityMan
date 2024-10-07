using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalFuits : MonoBehaviour
{
    private const string FruitKey = "TOTAL_FRUITS";
    int totalFruitsCollected;
    TMP_Text totalText;

    internal void CollecFruits()
    {
        totalFruitsCollected++;
        PlayerPrefs.SetInt(FruitKey, totalFruitsCollected);
        UpdateText();
    }

    private void UpdateText()
    {
        totalText.text = totalText.text = "Totall fruits : " + totalFruitsCollected;
    }

    private void Start()
    {
        totalText = GetComponent<TMP_Text>();
        totalFruitsCollected = PlayerPrefs.GetInt(FruitKey);
        UpdateText();
    }

}
