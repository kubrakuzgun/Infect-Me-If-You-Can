using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponWheel;

public class KellepacaHeal : MonoBehaviour
{
    public GameObject fpscontroller;
    public GameObject heal_icon;
    public GameObject kellep_obj;
    public GameObject kellep_hands;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (kellep_hands.GetComponent<Weapon>().noammo)
        {
            kellep_obj.SetActive(false);
            heal_icon.SetActive(false);
        }

        else if (!kellep_hands.GetComponent<Weapon>().noammo)
        {
            kellep_obj.SetActive(true);
            heal_icon.SetActive(true);

            if (Input.GetKeyDown(KeyCode.H))
            {
                kellep_hands.GetComponent<Weapon>().Shoot();

                if (fpscontroller.GetComponent<PlayerHealth>().health + 25 <= 100)
                {
                    fpscontroller.GetComponent<PlayerHealth>().health += 25;
                }
                else
                    fpscontroller.GetComponent<PlayerHealth>().health = 100;
            }

        }

    }
}
