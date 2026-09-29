using Chapter.Singleton;
using UnityEngine;

public class FlyingEnemy : EnemyBase
{

    [SerializeField]
    private GameObject bullet;


    public float maxTimer = 0.5f;
    private float timer;

    private Vector3 dir = new Vector3(1,0,0);


    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;


        if (timer <= 0)
        {

            attack();

            timer = maxTimer;
        }
    }


    private void FixedUpdate()
    {

        rb.linearVelocity = dir * 10;

    }







    public override void attack()
    {
        Debug.Log("attack");
        Vector3 dir = new Vector3(1,0,0);

        GameObject proj = Instantiate(bullet, transform);
        proj.GetComponent<EnergyProjectile>().SetVelocity(20, dir);
        proj.GetComponent<EnergyProjectile>().setProjectileDamage(100);
        proj.GetComponent<Projectile>().setLifeTime(3);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 3)
        {
            dir *= -1;
        }
    }
}
