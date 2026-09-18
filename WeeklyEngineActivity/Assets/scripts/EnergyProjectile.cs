using UnityEngine;

public class EnergyProjectile : Projectile
{


    private int directionBounce = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(10,0,0) * directionBounce;
    }



    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        directionBounce *=-1;
    }


}
