using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    private int score = 0;

    public int targetScore = 5;                 // คะแนนที่ต้องถึง
    public string winSceneName = "Win";    // ชื่อฉากที่ต้องโหลดเมื่อชนะ

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;

        if (score >= targetScore)
        {
            LoadWinScene();
        }
    }

    void LoadWinScene()
    {
        Debug.Log("Win! 🎉");
        SceneManager.LoadScene("Win");
    }
}