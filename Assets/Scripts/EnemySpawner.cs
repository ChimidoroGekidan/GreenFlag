using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private enum EnemyType { Slime, Goblin, Dragon }
    private enum Difficulty { Easy, Normal, Hard }

    private string[] enemies = { "スライム", "ゴブリン", "ドラゴン" };
    private string[] levels = { "かんたん", "ふつう", "むずかしい" };

    void Start()
    {
        Spawn(EnemyType.Slime, Difficulty.Hard);
    }

    void Spawn(EnemyType enemyType, Difficulty difficulty)
    {
        string enemy = enemies[(int)enemyType];
        string level = levels[(int)difficulty];
        Debug.Log(enemy + "が出現（難易度：" + level + "）");
    }
}