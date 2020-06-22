using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class SteamSanitizerConroller : MonoBehaviour
{
    public GameObject steam;
    public GameObject mainwep;
    // Start is called before the first frame update
    void Start()
    {
        steam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!mainwep.GetComponent<Weapon>()._isReloading && !mainwep.GetComponent<Weapon>().noammo)
            {
                mainwep.GetComponent<Weapon>().Shoot();
                steam.SetActive(true);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            steam.SetActive(false);
        }
    }

}
