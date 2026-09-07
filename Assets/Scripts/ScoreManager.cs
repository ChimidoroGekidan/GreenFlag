using UnityEngine;
 
public class ScoreManager : MonoBehaviour
{
    private int score = 100;
 
    public void AddPoints(int points)
    {
        score += points;
    }
 
    public int GetScoreValue()
    {
        return score;
    }
}
 