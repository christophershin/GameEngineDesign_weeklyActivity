using System.Collections.Generic;
using System.Linq;
using Chapter.Singleton;
using UnityEngine;
using UnityEngine.Pool;


public class ObjectPooling : Singleton<ObjectPooling>
{
    public int maxBulletAmount = 100;
    public GameObject objectPoolBullets;

    public List<GameObject> Pool;

    private void Start()
    {
        for (int i = 0; i < maxBulletAmount; i++)
        {

            GameObject b = Instantiate(objectPoolBullets, transform);
            b.GetComponent<ObjectPoolBullets>().Deavtivate();

            Pool.Add(b);
        }
    }


    public GameObject getInvalidProjectile()
    {

        for (int i = 0; i < maxBulletAmount; i++)
        {
            if (Pool[i].GetComponent<ObjectPoolBullets>().isActive == false)
            {



                return Pool[i];
                break;
            }

        }

        return null;
    }
}