using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineShot : MonoBehaviour
{
    public GameObject pillprefab;
    public Transform gunbarrel;
    public float forceamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject pill = Instantiate(pillprefab, gunbarrel.position, Quaternion.identity);
            Rigidbody rb = pill.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.detectCollisions = true;
            Quaternion initialRot = pillprefab.transform.rotation;
            
            pill.transform.rotation = initialRot * Quaternion.Euler(30.0f, 0.0f, 90.0f);

            //pill.GetComponent<Rigidbody>().AddForce(-gunbarrel.up * forceamount);

           // pill.GetComponent<Rigidbody>().AddForce((gunbarrel.up * (-1)) * forceamount, ForceMode.VelocityChange);
            pill.GetComponent<Rigidbody>().AddForce((gunbarrel.forward * (-1)) * forceamount, ForceMode.VelocityChange);

        }

    }
}
