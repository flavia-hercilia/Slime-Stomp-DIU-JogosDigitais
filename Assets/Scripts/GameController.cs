using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOver;
    public GameObject victoryScreen; 
    
    public static GameController instance;

    void Awake() 
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowVictoryScreen()
    {
        victoryScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToBegin()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); 
    }
}
