using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShoot : MonoBehaviour
{


    public GameObject portal1;
    public GameObject portal2;

    [SerializeField]
    private float portalSpeed = 20f;

    [SerializeField]
    private Camera cam;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ShootPortal();
        }
    }

    void ShootPortal()
    {
        Vector3 shootdirection = cam.transform.forward;
        
        

        if (portal1.GetComponent<portals>().GetFired() == false)
        {
            portal1.GetComponent<portals>().SetFired(true);
            portal2.GetComponent<portals>().SetFired(false);


            StartCoroutine(pauseEnableProj(portal1));
            portal1.transform.position = transform.position;
            portal1.GetComponent<portals>().SetVelocity(portalSpeed, shootdirection);
            //portal1.GetComponent<Rigidbody>().linearVelocity = shootdirection * 1000 * Time.deltaTime;
        }
        else if (portal2.GetComponent<portals>().GetFired() == false)
        {
            portal2.GetComponent<portals>().SetFired(true);
            portal1.GetComponent<portals>().SetFired(false);


            StartCoroutine(pauseEnableProj(portal2));
            portal2.transform.position = transform.position;
            portal2.GetComponent<portals>().SetVelocity(portalSpeed, shootdirection);
            //portal2.GetComponent<Rigidbody>().linearVelocity = shootdirection * 1000 * Time.deltaTime;
        }
        


        


    }


    private IEnumerator pauseEnableProj(GameObject proj)
    {

        proj.GetComponent<portals>().setVisible(false);
        yield return new WaitForSecondsRealtime(0.1f);
        proj.GetComponent<portals>().setVisible(true);
    }

}
