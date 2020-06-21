using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Pill" || collision.collider.tag != "OtherPills" || collision.collider.tag != "Player")
        {
           Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Ground")
        {
            Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            Collider col = this.gameObject.GetComponent<Collider>();
            col.enabled = false;
        }
    }
}
