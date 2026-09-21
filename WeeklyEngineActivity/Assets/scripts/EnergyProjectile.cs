using Unity.AppUI.Core;
using UnityEngine;

public class EnergyProjectile : Projectile
{


    private int directionBounce = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    new void Start()
    {
        base.Start();
        
    }


    new void Update()
    {
        base.Update();
        Vector3 dir = new Vector3(1, 0, 0) * directionBounce;
        SetVelocity(10, dir);

    }


    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        directionBounce *=-1;
    }


}
