using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 100;

    void Start()
    {
        Debug.Log("スコア: " + GetScoreValue());
        AddPoints(50);
        Debug.Log("50点追加後のスコア: " + GetScoreValue());
    }

    public void AddPoints(int points)
    {
        score += points;
    }

    public int GetScoreValue()
    {
        return score;
    }
}