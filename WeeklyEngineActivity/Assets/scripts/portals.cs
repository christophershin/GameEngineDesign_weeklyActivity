using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class portals : Projectile
{

    private bool fired = false;
    private bool visible = false;
    public GameObject otherPortal;

    new void Start()
    {
        base.Start();
        SetFired(false);
    }



    // Update is called once per frame
    void Update()
    {
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

    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        if (other.gameObject.CompareTag("Player"))
        {
            if (visible)
            {
                other.gameObject.transform.position = otherPortal.transform.position;
                other.GetComponent<Rigidbody>().linearVelocity = transform.up * 10;
            }
        }
    }
}
