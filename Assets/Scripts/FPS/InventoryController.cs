using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponWheel;

public class InventoryController : MonoBehaviour
{
    public bool trigerred=false;
    public GameObject pickup_icon, player;
    public GameObject syrgun, medgun, lqgun, stgun, kolonya_hands, mask_hands, scw_hands, kellep_hands;
    public int kolonya, maske, ilac, kapsul, sicvepis, kellepaca, borel, steam;
    // Start is called before the first frame update
    void Start()
    {
        pickup_icon.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {



    }

    
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Kapsul" || other.tag == "Medicine" || other.tag == "Borel" || other.tag == "Steam" || other.tag == "Kolonya" || other.tag == "MaskPack" || other.tag == "Sicvepis" || other.tag == "KellePaca")
        {
            trigerred = true;
            pickup_icon.SetActive(true);
        }


        if (trigerred)
        {
            if (other.tag == "Kapsul" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                kapsul++;
                syrgun.GetComponent<Weapon>().ClipSize += kapsul;
                syrgun.GetComponent<Weapon>().ammo = syrgun.GetComponent<Weapon>().ClipSize;
                syrgun.GetComponent<Weapon>().ammoInUse = syrgun.GetComponent<Weapon>().ClipSize;
                syrgun.GetComponent<Weapon>().noammo = false;
            }

            else if (other.tag == "Medicine" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                ilac += 2;
                medgun.GetComponent<Weapon>().ClipSize += ilac;
                medgun.GetComponent<Weapon>().ammo = medgun.GetComponent<Weapon>().ClipSize;
                medgun.GetComponent<Weapon>().ammoInUse = medgun.GetComponent<Weapon>().ClipSize;
                medgun.GetComponent<Weapon>().noammo = false;
            }

            else if (other.tag == "Borel" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                borel += 5;
                lqgun.GetComponent<Weapon>().ClipSize += borel;
                lqgun.GetComponent<Weapon>().ammo = lqgun.GetComponent<Weapon>().ClipSize;
                lqgun.GetComponent<Weapon>().ammoInUse = lqgun.GetComponent<Weapon>().ClipSize;
                lqgun.GetComponent<Weapon>().noammo = false;
            }

            /*
            if (other.tag == "Steam" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                steam += 50;
                stgun.GetComponent<Weapon>().ClipSize += steam;
                stgun.GetComponent<Weapon>().ammo += steam;
                stgun.GetComponent<Weapon>().ammoInUse += steam;
                stgun.GetComponent<Weapon>().noammo = false;
            } */

            else if (other.tag == "Kolonya" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                kolonya++;
                kolonya_hands.GetComponent<Weapon>().ClipSize += kolonya;
                kolonya_hands.GetComponent<Weapon>().ammo = kolonya_hands.GetComponent<Weapon>().ClipSize;
                kolonya_hands.GetComponent<Weapon>().ammoInUse = kolonya_hands.GetComponent<Weapon>().ClipSize;
                kolonya_hands.GetComponent<Weapon>().noammo = false;
            }

            else if (other.tag == "MaskPack" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                maske++;
                mask_hands.GetComponent<Weapon>().ClipSize += maske;
                mask_hands.GetComponent<Weapon>().ammo = mask_hands.GetComponent<Weapon>().ClipSize;
                mask_hands.GetComponent<Weapon>().ammoInUse = mask_hands.GetComponent<Weapon>().ClipSize;
                mask_hands.GetComponent<Weapon>().noammo = false;
            }

            else if (other.tag == "Sicvepis" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                sicvepis++;
                scw_hands.GetComponent<Weapon>().ClipSize += sicvepis;
                scw_hands.GetComponent<Weapon>().ammo = scw_hands.GetComponent<Weapon>().ClipSize;
                scw_hands.GetComponent<Weapon>().ammoInUse = scw_hands.GetComponent<Weapon>().ClipSize;
                scw_hands.GetComponent<Weapon>().noammo = false;
            }

            else if (other.tag == "KellePaca" && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                trigerred = false;
                kellepaca++;
                kellep_hands.GetComponent<Weapon>().ClipSize += kellepaca;
                kellep_hands.GetComponent<Weapon>().ammo = kellep_hands.GetComponent<Weapon>().ClipSize;
                kellep_hands.GetComponent<Weapon>().ammoInUse = kellep_hands.GetComponent<Weapon>().ClipSize;
                kellep_hands.GetComponent<Weapon>().noammo = false;
            }

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            pickup_icon.SetActive(false);
        }

    }


    public void OnTriggerExit(Collider other)
    {
        pickup_icon.SetActive(false);
        trigerred = false;
    }

    public void afterPickUp()
    {
        pickup_icon.SetActive(false);
    }


}