using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LosePanel : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private void Start()
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int highScore = PlayerPrefs.GetInt("highScore");
        if (lastRunScore > highScore)
        {
            highScore = lastRunScore;
            PlayerPrefs.SetInt("highScore", highScore);
            scoreText.text = "High score: " + highScore.ToString();
        }
        else
        {
            scoreText.text =  "High score: " + highScore.ToString();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
