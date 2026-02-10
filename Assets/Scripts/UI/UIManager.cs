using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreDisplay();
    }

    public void UpdateScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Call this method to reset UI for a new game
    public void ResetUI()
    {
        score = 0;
        UpdateScoreDisplay();
    }
}