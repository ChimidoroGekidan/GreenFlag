using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;

    private int jumpsUsed = 0;
    private int maxJumps = 2;

    void Start()
    {
        Jump();
        Land();
        Debug.Log("着地後、もう一度ジャンプできるか確認します");
        Jump();
    }

    public void Jump()
    {
        if (jumpsUsed < maxJumps)
        {
            jumpsUsed++;
            if (playerRigidbody != null)
            {
                playerRigidbody.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
            }
            Debug.Log("ジャンプ成功");
        }
        else
        {
            Debug.Log("ジャンプできない");
        }
    }

    public void Land()
    {
        jumpsUsed = 0;
        Debug.Log("着地");
    }
}