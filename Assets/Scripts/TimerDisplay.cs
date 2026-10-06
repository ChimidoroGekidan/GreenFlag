using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    private int frameCount = 0;
    private int targetFrame = 3;
    private bool isFinished = false;

    void Start()
    {
        Debug.Log("3フレーム後にメッセージが出るはずです");
    }

    void Update()
    {
        frameCount++;
        if (!isFinished && frameCount == targetFrame)
        {
            isFinished = true;
            Debug.Log("3フレーム経過しました");
        }
    }
}