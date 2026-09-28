using Unity.AppUI.Core;
using UnityEngine;
using UnityEngine.UIElements;

public class EnergyProjectile : Projectile
{

    [SerializeField]
    private float damage = 1;


    new void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.layer == 3) {
            Debug.Log("hit");

            dir *= -1;
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
