using UnityEngine;

public class Projectile : MonoBehaviour, IMoveable 
{


    protected Rigidbody rb;
    public bool destroyOnCollision = true;

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


    public void Move(bool _canMove)
    {
        rb.linearVelocity = new Vector3(0, 0, 0);
    }

}
