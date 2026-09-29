using Unity.AppUI.Core;
using UnityEngine;
using UnityEngine.UIElements;

public class EnergyProjectile : Projectile,IcanDamage
{




    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        if(other.gameObject.layer == 3) {
            Debug.Log("hit");

            dir *= -1;
        }
    }


}
