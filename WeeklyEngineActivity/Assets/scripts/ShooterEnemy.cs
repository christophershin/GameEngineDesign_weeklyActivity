using Chapter.Singleton;
using UnityEngine;

public class ShooterEnemy : EnemyBase
{

    public GameObject projectile;

    public float max_atk_timer = 1f;
    private float atk_timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        atk_timer -= Time.deltaTime;

        if (atk_timer <= 0)
        {

            attack();


            atk_timer = max_atk_timer;
        }
    }


    public override void attack()
    {
        Debug.Log("attack");
        Vector3 dir = LevelManager.Instance.player.transform.position - transform.position;

        GameObject proj = Instantiate(projectile, transform);
        proj.GetComponent<EnergyProjectile>().SetVelocity(10, dir);
        proj.GetComponent<EnergyProjectile>().setProjectileDamage(100);
        proj.GetComponent<EnergyProjectile>().setLifeTime(8);
        proj.GetComponent<EnergyProjectile>().canMoveAfterHitWall = false;
        proj.GetComponent<EnergyProjectile>().destroyOnCollision = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dangerous") && other.gameObject.layer == 3){
            Destroy(gameObject);
        }
    }

}
