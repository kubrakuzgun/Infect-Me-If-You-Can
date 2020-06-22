using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class RemainingMask : MonoBehaviour
{
    public GameObject mask_hands, mask_obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mask_hands.GetComponent<Weapon>().noammo)
        {
            mask_obj.SetActive(false);
        }
        else if (!mask_hands.GetComponent<Weapon>().noammo)
        {
            mask_obj.SetActive(true);
        }
    }
}
