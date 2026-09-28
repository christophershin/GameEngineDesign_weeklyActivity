using Unity.AppUI.Core;
using UnityEngine;
using UnityEngine.UIElements;

public class EnergyProjectile : Projectile
{

    [SerializeField]
    private float damage = 1;

    private int directionBounce = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    new void Start()
    {
        base.Start();
        
    }


    new void Update()
    {
        base.Update();

    }


    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if(other.gameObject.layer == 3) {
            Debug.Log("hit");
            directionBounce *= -1;
            dir *= directionBounce;

        }
    }


    public float getProjectileDamage()
    {
        return damage;
    }


    public void setProjectileDamage(float _dmg)
    {
        damage = _dmg;
    }
}
