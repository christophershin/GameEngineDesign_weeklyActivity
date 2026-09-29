using Unity.AppUI.Core;
using UnityEngine;

public class Projectile : MonoBehaviour, IMoveable, IcanDamage
{


    protected Rigidbody rb;
    public bool destroyOnCollision = true;
    public bool canMoveAfterHitWall = false;
    protected float speed;
    protected Vector3 dir;

    protected float lifetime = 1;


    [SerializeField]
    private float damage = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Move(canMoveAfterHitWall);
            if (destroyOnCollision)
            {
                Destroy(gameObject);
            }

        }
    }

    protected void Update()
    {
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }




    private void FixedUpdate()
    {
        rb.linearVelocity = dir * speed;
    }

    public void SetVelocity(float _Speed, Vector3 _Dir)
    {
        speed = _Speed;
        dir = _Dir.normalized;
    }


    public void Move(bool _canMove)
    {
        if (!_canMove)
        {
            speed = 0;
        }
    }

    public void DealDamage(float _dmg)
    {

    }


    public float getProjectileDamage()
    {
        return damage;
    }


    public void setProjectileDamage(float _dmg)
    {
        damage = _dmg;
    }

    public void setLifeTime(float _time)
    {
        lifetime = _time;
    }
}
