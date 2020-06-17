using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class SyringeShot : MonoBehaviour
{
    public GameObject needleprefab;
    public GameObject mainwep;
    public Transform gunbarrel;
    public float forceamount;
    Vector3 newscale;
    // Start is called before the first frame update
    void Start()
    {
        newscale = new Vector3(0.03f, 0.03f, 0.03f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!mainwep.GetComponent<Weapon>()._isReloading)
            {
                mainwep.GetComponent<Weapon>().Shoot();
                GameObject syringe = Instantiate(needleprefab, gunbarrel.position, Quaternion.identity);
                Rigidbody rb = syringe.GetComponent<Rigidbody>();
                rb.useGravity = true;
                Quaternion initialRot = needleprefab.transform.rotation;

                syringe.transform.rotation = initialRot * Quaternion.Euler(6.0f, -30.0f, -2.0f);
                syringe.transform.localScale += newscale;

                // syringe.GetComponent<Rigidbody>().AddForce(gunbarrel.forward * forceamount, ForceMode.VelocityChange);
                syringe.GetComponent<Rigidbody>().AddForce((gunbarrel.right * -1) * forceamount);

            }

        }

    }
}
