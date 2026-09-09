using UnityEngine;
 
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
 
    private int jumpsUsed = 0;
    private int maxJumps = 2;
 
    public void Jump()
    {
        if (jumpsUsed < maxJumps)
        {
            jumpsUsed++;
            rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
 
    public void Land()
    {
        jumpsUsed = 0;
    }
}