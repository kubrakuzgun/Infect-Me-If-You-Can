using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class ScwHeal : MonoBehaviour
{
    public GameObject fpscontroller;
    public GameObject heal_icon;
    public GameObject scw_obj;
    public GameObject scw_hands;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scw_hands.GetComponent<Weapon>().noammo)
        {
            scw_obj.SetActive(false);
            heal_icon.SetActive(false);
        }

        else if (!scw_hands.GetComponent<Weapon>().noammo) 
        {
            scw_obj.SetActive(true);
            heal_icon.SetActive(true);

            if (Input.GetKeyDown(KeyCode.H))
            {
                    scw_hands.GetComponent<Weapon>().Shoot();

                    if (fpscontroller.GetComponent<PlayerHealth>().health + 10 <= 100)
                    {
                        fpscontroller.GetComponent<PlayerHealth>().health += 10;
                    }
                    else
                        fpscontroller.GetComponent<PlayerHealth>().health = 100;   
            }


        } 



    }
}
