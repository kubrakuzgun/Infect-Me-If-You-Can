using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class MedicineShot : MonoBehaviour
{
    public GameObject pillprefab;
    public GameObject mainwep;
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
            if (!mainwep.GetComponent<Weapon>()._isReloading && !mainwep.GetComponent<Weapon>().noammo)
            {
                mainwep.GetComponent<Weapon>().Shoot();
                GameObject pill = Instantiate(pillprefab, gunbarrel.position, Quaternion.identity);
                Rigidbody rb = pill.GetComponent<Rigidbody>();
                rb.useGravity = true;
                Quaternion initialRot = pillprefab.transform.rotation;

                pill.transform.rotation = initialRot * Quaternion.Euler(30.0f, 0.0f, 90.0f);

                pill.GetComponent<Rigidbody>().AddForce((gunbarrel.up * (-1)) * forceamount);
            }
               

        }

        else
        {

            Rigidbody prb = pillprefab.GetComponent<Rigidbody>();
            prb.useGravity = false;
        }


    }
}
