using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int hp = 30;

    void Start()
    {
        Debug.Log("--- 5ダメージ（まだ生きている想定） ---");
        TakeDamage(5);
    }

    public void TakeDamage(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            Debug.Log("撃破！");
            Debug.Log("ドロップアイテムを生成");
        }
    }
}