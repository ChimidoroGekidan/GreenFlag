using UnityEngine;
 
public class GameManager : MonoBehaviour
{
    [SerializeField] private ResultPanel resultPanel;
 
    private int score = 0;
    private int highScore = 0;
    private bool isBonusStage = false;
 
    public void EndLevel()
    {
        Time.timeScale = 0f;
        UpdateHighScore();
        if (isBonusStage)
        {
            return;
        }
        resultPanel.Show(score);
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
 