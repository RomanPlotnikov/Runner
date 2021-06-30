using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public TMP_Text scoreText;
    private int totalScore;

    public int scoreMultiplier;

    private void FixedUpdate()
    {
        totalScore += scoreMultiplier;
        scoreText.text = totalScore.ToString();
    }
}
