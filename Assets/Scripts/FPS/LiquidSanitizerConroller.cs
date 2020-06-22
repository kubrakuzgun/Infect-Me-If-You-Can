﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class LiquidSanitizerConroller : MonoBehaviour
{
    public GameObject liquid;
    public GameObject mainwep;

    // Start is called before the first frame update
    void Start()
    {
        liquid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!mainwep.GetComponent<Weapon>()._isReloading && !mainwep.GetComponent<Weapon>().noammo)
            {
                mainwep.GetComponent<Weapon>().Shoot();
                liquid.SetActive(true);
            }
        }
        else 
        {
            WaitSec();
        }
    }

    public IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(2f);
        liquid.SetActive(false);
    }
}

