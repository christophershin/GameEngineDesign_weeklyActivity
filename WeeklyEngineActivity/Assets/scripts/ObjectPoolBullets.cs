using UnityEngine;
using UnityEngine.Pool;
using System.Collections;

public class ObjectPoolBullets : Projectile
{

    public bool isActive;

    void OnTriggerEnter(Collider other)
    {
        if (isActive)
        {
            if (other.gameObject.layer == 3)
            {

                if (destroyOnCollision)
                {
                    Deavtivate();
                }

            }
        }
    }

    void Update()
    {

        if (isActive)
        {
            if (hasLifetime)
            {
                lifetime -= Time.deltaTime;

                if (lifetime <= 0)
                {
                    Deavtivate();
                }
            }
        }
    }


    public void Deavtivate()
    {
        this.gameObject.SetActive(false);
        isActive = false;
    }


    public void Activate()
    {
        this.gameObject.SetActive(true);
        isActive = true;
    }
}