using UnityEngine;

public class FlyingEnemySpawner : EnemySpawner
{



    public GameObject enemyPrefab;

    public override EnemyBase SpawnEnemy()
    {
        GameObject enemyOBJ = Instantiate(enemyPrefab, transform);
        return enemyOBJ.GetComponent<EnemyBase>();
    }
}
