using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public bool isGameOver;
    public Bird bird;
    public Text scoreText;
    public AudioSource pointSFX;
    public GameObject gameOverScreen;
    public TextMeshProUGUI finalScore, highScore;

    void Start()
    {
        if(PlayerPrefs.GetInt("HighScore", 0) == 0)
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        pointSFX.Play();
    }

    public void menuReturn()
    {
        SceneManager.LoadSceneAsync("Tittle Scene");
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        bird.GetComponent<CircleCollider2D>().enabled = false;
        gameOverScreen.SetActive(true);
        isGameOver = true;
        finalScore.text = playerScore.ToString();
        if (playerScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        highScore.text = "High Score\n" + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
