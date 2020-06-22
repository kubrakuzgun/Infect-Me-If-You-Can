using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponWheel;

public class MaskShot : MonoBehaviour
{
    public GameObject maskprefab, maskobj;
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
        
       /* if (mainwep.GetComponent<Weapon>().noammo)
        {
            maskobj.SetActive(false);
        } */

        if(!mainwep.GetComponent<Weapon>().noammo)
        {
           // maskobj.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                    mainwep.GetComponent<Weapon>().Shoot();
                    GameObject mask = Instantiate(maskprefab, gunbarrel.position, Quaternion.identity);
                    Rigidbody rb = mask.GetComponent<Rigidbody>();
                    rb.useGravity = true;
                    Quaternion initialRot = maskprefab.transform.rotation;

                    mask.transform.rotation = initialRot * Quaternion.Euler(0.0f, 0.0f, 0.0f);

                    mask.GetComponent<Rigidbody>().AddForce((gunbarrel.right * (-1)) * forceamount);
            }
            else
            {

                    Rigidbody mrb = maskprefab.GetComponent<Rigidbody>();
                    mrb.useGravity = false;
            }
        }
        

    }
}
