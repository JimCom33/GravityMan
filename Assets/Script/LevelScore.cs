using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelScore : MonoBehaviour
{
    [SerializeField] TMP_Text levelScore;

    int score;
    
    public void AddScore(int value)
    {
        score += value;
        levelScore.text = "Fruits collected in level : " + score;
    }
}
