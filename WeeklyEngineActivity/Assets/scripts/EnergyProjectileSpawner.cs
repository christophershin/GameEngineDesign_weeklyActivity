using UnityEngine;

public class EnergyProjectileSpawner : EnemySpawner
{

    public GameObject enemyPrefab;


    public override EnemyBase SpawnEnemy()
    {
        Vector3 dir = new Vector3(1, 0, 0);

        GameObject enemyOBJ = Instantiate(enemyPrefab, transform);
        enemyOBJ.GetComponent<EnergyProjectile>().SetVelocity(10, dir);
        return enemyOBJ.GetComponent<EnemyBase>();
    }


}
