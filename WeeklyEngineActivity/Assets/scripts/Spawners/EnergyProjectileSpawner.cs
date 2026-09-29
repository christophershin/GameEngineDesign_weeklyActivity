using UnityEngine;

public class EnergyProjectileSpawner : ProjectileSpawner
{

    public GameObject enemyPrefab;


    public override Projectile SpawnProjectile()
    {
        Vector3 dir = new Vector3(1, 0, 0);

        GameObject enemyOBJ = Instantiate(enemyPrefab, transform);
        enemyOBJ.GetComponent<EnergyProjectile>().SetVelocity(10, dir);
        return enemyOBJ.GetComponent<Projectile>();
    }


}
