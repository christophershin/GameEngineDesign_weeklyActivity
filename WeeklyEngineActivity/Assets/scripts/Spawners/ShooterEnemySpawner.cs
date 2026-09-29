using UnityEngine;

public class ShooterEnemySpawner : EnemySpawner
{

    public GameObject enemyPrefab;

    public override EnemyBase SpawnEnemy()
    {
        GameObject enemyOBJ = Instantiate(enemyPrefab, transform);
        return enemyOBJ.GetComponent<EnemyBase>();
    }



}
