using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class RemainingKolonya : MonoBehaviour
{
    public GameObject kolonya_hands, kolonya_obj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kolonya_hands.GetComponent<Weapon>().noammo)
        {
            kolonya_obj.SetActive(false);
        }
        else if (!kolonya_hands.GetComponent<Weapon>().noammo)
        {
            kolonya_obj.SetActive(true);
        }
    }
}
