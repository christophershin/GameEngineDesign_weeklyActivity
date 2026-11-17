using Unity.VisualScripting;
using UnityEngine;

public class ObjectPoolShooting : EnemyBase
{

    public float maxTimer = 0.5f;
    private float timer = 0.5f;

    public float speed;

    private Vector3 dir = new Vector3(1, 0, 0);


    // Update is called once per frame
    void Update()
    {
        attack();

    }


    private void FixedUpdate()
    {

        rb.linearVelocity = dir * speed;

    }







    public override void attack()
    {
        Debug.Log("attack");
        Vector3 dir = new Vector3(0, 0, -1);
        GameObject bullet;


            
        bullet = ObjectPooling.Instance.getInvalidProjectile();
        if (bullet)
        {
            bullet.transform.position = transform.position;
            bullet.GetComponent<ObjectPoolBullets>().Activate();
            bullet.GetComponent<Projectile>().SetVelocity(20, dir);
            bullet.GetComponent<Projectile>().setLifeTime(1.5f);
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 3)
        {
            dir *= -1;
        }
    }
}
