using UnityEngine;
 
public class PlayerHealth : MonoBehaviour
{
    private int hp = 100;
 
    public void TakeDamageFromEnemy(int amount)
    {
        Debug.Log("敵からダメージを受けた");
        ApplyDamage(amount);
    }
 
    public void TakeDamageFromHazard(int amount)
    {
        Debug.Log("トラップのダメージを受けた");
        ApplyDamage(amount);
    }
 
    private void ApplyDamage(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            Die();
        }
    }
 
    private void Die()
    {
        Debug.Log("プレイヤーが死亡した");
    }
}
 