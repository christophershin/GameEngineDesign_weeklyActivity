using Chapter.Singleton;
using UnityEngine;

public class FlyingEnemy : EnemyBase
{

    [SerializeField]
    private GameObject bullet;


    public float maxTimer = 0.5f;
    private float timer = 0.5f;

    private Vector3 dir = new Vector3(1,0,0);


    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;


        if (timer <= 0.0)
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
        Vector3 dir = new Vector3(0,0,-1);

        GameObject proj = Instantiate(bullet, transform);
        proj.GetComponent<Projectile>().SetVelocity(20, dir);
        proj.GetComponent<Projectile>().setProjectileDamage(20);
        proj.GetComponent<Projectile>().setLifeTime(1.5f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 3)
        {
            dir *= -1;
        }
    }
}
