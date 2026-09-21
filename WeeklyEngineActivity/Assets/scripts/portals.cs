using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class portals : Projectile
{

    private bool fired = false;
    private bool visible = false;
    public GameObject otherPortal;
    private Vector3 collisionDir;
    public LayerMask layer;
    private float teleportTimer = 0.25f;
    private float timer = 0;


    new void Start()
    {
        base.Start();
        SetFired(false);
    }



    // Update is called once per frame
    new void Update()
    {
        base.Update();

        timer -= Time.deltaTime;

        if (visible)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }



    public void setVisible(bool _visibility)
    {
        visible = _visibility;
    }

    public bool getVisibility()
    {
        return visible;
    }


    public void SetFired(bool _fired)
    {
        fired = _fired;
    }


    public bool GetFired()
    {
        return fired;
    }

    public Vector3 getCollisionDIR()
    {
        return collisionDir;
    }


    public void setTimer(float _time)
    {
        timer = _time;
    }



    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);


        registerRayDirection();


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (timer <= 0)
            {
                if (visible && otherPortal.GetComponent<portals>().visible)
                {
                    other.gameObject.transform.position = otherPortal.transform.position + otherPortal.GetComponent<portals>().getCollisionDIR() * 3;
                    other.GetComponent<Rigidbody>().linearVelocity += otherPortal.GetComponent<portals>().getCollisionDIR() * 3;
                }

                timer = teleportTimer;
                otherPortal.GetComponent<portals>().setTimer(teleportTimer);
            }
        }
    }







    void registerRayDirection()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1, layer))
        {
            Debug.Log("Did forward");
            collisionDir = transform.TransformDirection(Vector3.back);
        }
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, 1, layer))
        {
            Debug.Log("Did back");
            collisionDir = transform.TransformDirection(Vector3.forward);
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 1, layer))
        {
            Debug.Log("Did right");
            collisionDir = transform.TransformDirection(Vector3.left);
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 1, layer))
        {
            Debug.Log("Did left");
            collisionDir = transform.TransformDirection(Vector3.right);
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, 1, layer))
        {
            Debug.Log("Did up");
            collisionDir = transform.TransformDirection(Vector3.down);
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 1, layer))
        {
            Debug.Log("Did down");
            collisionDir = transform.TransformDirection(Vector3.up);
        }
    }
}
