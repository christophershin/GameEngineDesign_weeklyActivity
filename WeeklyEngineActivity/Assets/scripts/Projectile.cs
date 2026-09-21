using Unity.AppUI.Core;
using UnityEngine;

public class Projectile : MonoBehaviour, IMoveable 
{


    protected Rigidbody rb;
    public bool destroyOnCollision = true;
    private bool canMove = true;
    private float speed;
    private Vector3 dir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Move(false);
            if (destroyOnCollision)
            {
                Destroy(gameObject);
            }

        }
    }

    protected void Update()
    {

       transform.position += dir * speed * Time.deltaTime;
        
            
    }

    public void SetVelocity(float _portalSpeed, Vector3 _portalDir)
    {
        speed = _portalSpeed;
        dir = _portalDir;
    }


    public void Move(bool _canMove)
    {
        speed = 0;
    }

}
