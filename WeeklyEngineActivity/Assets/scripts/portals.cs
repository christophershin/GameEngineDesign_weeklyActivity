using UnityEditor.UI;
using UnityEngine;

public class portals : MonoBehaviour
{

    public bool fired = false;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            rb.linearVelocity = new Vector3(0, 0, 0);
        }
    }
}
