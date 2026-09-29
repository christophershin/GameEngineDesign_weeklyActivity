using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{

    protected Rigidbody rb;



    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public abstract void attack();


}
