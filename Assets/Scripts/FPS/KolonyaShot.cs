using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class KolonyaShot : MonoBehaviour
{
    public GameObject kolonyaprefab, kolonyaobj, kolonyaobj2;
    public GameObject mainwep;
    public Transform gunbarrel;
    public float forceamount;
    // Start is called before the first frame update
    void Start()
    {
      //  kolonyaobj.SetActive(true);
      //  kolonyaobj2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

      /*  if (mainwep.GetComponent<Weapon>().noammo)
        {
            kolonyaobj.SetActive(false);
            kolonyaobj2.SetActive(false);
        }
        else if(!mainwep.GetComponent<Weapon>().noammo)
        {
            kolonyaobj.SetActive(true);
            kolonyaobj2.SetActive(true);
        }
        */

        if (Input.GetMouseButtonDown(0))
        {
            if (!mainwep.GetComponent<Weapon>()._isReloading && !mainwep.GetComponent<Weapon>().noammo)
            {
                mainwep.GetComponent<Weapon>().Shoot();
                GameObject kolonya = Instantiate(kolonyaprefab, gunbarrel.position, Quaternion.identity);
                Rigidbody rb = kolonya.GetComponent<Rigidbody>();
                rb.useGravity = true;
                Quaternion initialRot = kolonyaprefab.transform.rotation;

                kolonya.transform.rotation = initialRot * Quaternion.Euler(0.0f, 0.0f, 0.0f);

                //kolonya.GetComponent<Rigidbody>().AddForce((gunbarrel.forward) * forceamount);
                kolonya.GetComponent<Rigidbody>().AddForce((gunbarrel.right * (-1)) * forceamount);
            }


        }
    }
}
