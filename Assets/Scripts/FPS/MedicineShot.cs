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
            Quaternion initialRot = pillprefab.transform.rotation;

            pill.transform.rotation = initialRot;

            // syringe.GetComponent<Rigidbody>().AddForce(gunbarrel.forward * forceamount, ForceMode.VelocityChange);
            pill.GetComponent<Rigidbody>().AddForce(Vector3.up * forceamount);
        }

    }
}
