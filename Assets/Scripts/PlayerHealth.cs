using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // 最大HPは100
    private int maxHp = 100;

    // 初期HPは100
    private int hp = 100;

    void Start()
    {
        Debug.Log("最大HP: " + maxHp);
        Debug.Log("初期HP: " + hp);
        TakeDamage(150);
        Debug.Log("150ダメージ後のHP: " + hp);
        Heal(500);
        Debug.Log("500回復後のHP: " + hp);
    }

    // HPを減らす（0より小さくならない）
    public void TakeDamage(int amount)
    {
        hp = Mathf.Max(hp - amount, 0);
    }

    // HPを回復する（最大HPを超えない）
    public void Heal(int amount)
    {
        hp = Mathf.Min(hp + amount, maxHp);
    }
}