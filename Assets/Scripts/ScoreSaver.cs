using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";
 
    private int score = 0;
 
    public void AddPoints(int amount)
    {
        score += amount;
        PlayerPrefs.SetInt(HighScoreKey, score);
    }
 
    public int LoadHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey);
    }
}
