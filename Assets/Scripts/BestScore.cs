using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameManager GameManager { get { return gameManager; } }
    public UIManager UIManager { get { return uiManager; } }

    int score = 0;
    int bestScore = 0;
    GameManager gameManager;
    UIManager uiManager;

    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update

    // 조건문 게임오버되었을 때 score > bestScore라면
    // score를 bestScore로 업데이트하고
    // UI에 bestScore를 업데이트한다.
    public void UpdateBestScore(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
    public void CheckAndUpdateBestScore(int score, int bestScore)
    {
        if (score > bestScore)
        {
            bestScore = score;
            UpdateBestScore(bestScore);
        }
    }

    private void Start()
    {
        Debug.Log("BestScore Start");
        int bestScore = PlayerPrefs.GetInt("BestScore");
        Debug.Log("BestScore: " + bestScore);

        UpdateScore(bestScore);
    }
}
