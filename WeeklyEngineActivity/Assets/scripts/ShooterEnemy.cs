using Chapter.Singleton;
using UnityEngine;

public class ShooterEnemy : EnemyBase
{

    public GameObject projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void attack()
    {
        Debug.Log("attack");
        Vector3 dir = LevelManager.Instance.player.transform.position;

        GameObject proj = Instantiate(projectile, transform);
        proj.GetComponent<EnergyProjectile>().SetVelocity(10, dir);
        proj.GetComponent<EnergyProjectile>().setProjectileDamage(50);
    }
}
