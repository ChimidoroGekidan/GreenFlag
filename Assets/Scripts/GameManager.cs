using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ResultPanel resultPanel;

    private int score = 0;
    private int highScore = 0;
    private bool isBonusStage = false;

    void Start()
    {
        PlayerPrefs.DeleteKey("HighScore");
        isBonusStage = true;
        score = 999;
        Debug.Log("ボーナスステージ、スコア999でレベル終了します");
        EndLevel();
        Debug.Log("保存されたハイスコア: " + PlayerPrefs.GetInt("HighScore"));
    }

    public void EndLevel()
    {
        Time.timeScale = 0f;
        UpdateHighScore();
        if (isBonusStage)
        {
            return;
        }
        if (resultPanel != null)
        {
            resultPanel.Show(score);
        }
    }

    private void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}