using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponWheel;

public class InventoryController : MonoBehaviour
{
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
        if (other.tag == "Kapsul" || other.tag == "Medicine" || other.tag == "Borel" || other.tag == "Steam" || other.tag == "Kolonya" || other.tag == "MaskPack" || other.tag == "Sicvepis" || other.tag == "KellePaca")
        {
            pickup_icon.SetActive(true);
        }
        

    }

    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Kapsul" && Input.GetKeyDown(KeyCode.E))
        {
            kapsul+=5;
            syrgun.GetComponent<Weapon>().ClipSize += kapsul;
            syrgun.GetComponent<Weapon>().ammo += kapsul;
            syrgun.GetComponent<Weapon>().ammoInUse += kapsul;
            syrgun.GetComponent<Weapon>().noammo =false;
            other.gameObject.SetActive(false);
            
        }

        if (other.tag == "Medicine" && Input.GetKeyDown(KeyCode.E))
        {
            ilac+=5;
            medgun.GetComponent<Weapon>().ClipSize += ilac;
            medgun.GetComponent<Weapon>().ammo += ilac;
            medgun.GetComponent<Weapon>().ammoInUse += ilac;
            medgun.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Borel" && Input.GetKeyDown(KeyCode.E))
        {
            borel+=10;
            lqgun.GetComponent<Weapon>().ClipSize += borel;
            lqgun.GetComponent<Weapon>().ammo += borel;
            lqgun.GetComponent<Weapon>().ammoInUse += borel;
            lqgun.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Steam" && Input.GetKeyDown(KeyCode.E))
        {
            steam+=15;
            stgun.GetComponent<Weapon>().ClipSize += steam;
            stgun.GetComponent<Weapon>().ammo += steam;
            stgun.GetComponent<Weapon>().ammoInUse += steam;
            stgun.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Kolonya" && Input.GetKeyDown(KeyCode.E))
        {
            kolonya++;
            kolonya_hands.GetComponent<Weapon>().ClipSize += steam;
            kolonya_hands.GetComponent<Weapon>().ammo += steam;
            kolonya_hands.GetComponent<Weapon>().ammoInUse += steam;
            kolonya_hands.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "MaskPack" && Input.GetKeyDown(KeyCode.E))
        {
            maske+=10;
            mask_hands.GetComponent<Weapon>().ClipSize += steam;
            mask_hands.GetComponent<Weapon>().ammo += steam;
            mask_hands.GetComponent<Weapon>().ammoInUse += steam;
            mask_hands.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Sicvepis" && Input.GetKeyDown(KeyCode.E))
        {
            sicvepis++;
            scw_hands.GetComponent<Weapon>().ClipSize += steam;
            scw_hands.GetComponent<Weapon>().ammo += steam;
            scw_hands.GetComponent<Weapon>().ammoInUse += steam;
            scw_hands.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "KellePaca" && Input.GetKeyDown(KeyCode.E))
        {
            kellepaca++;
            kellep_hands.GetComponent<Weapon>().ClipSize += steam;
            kellep_hands.GetComponent<Weapon>().ammo += steam;
            kellep_hands.GetComponent<Weapon>().ammoInUse += steam;
            kellep_hands.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            pickup_icon.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Kapsul" || other.tag == "Medicine" || other.tag == "Borel" || other.tag == "Steam" || other.tag == "Kolonya" || other.tag == "MaskPack" || other.tag == "Sicvepis" || other.tag == "KellePaca")
        {
            pickup_icon.SetActive(false);
        }
    }
    
    public void afterPickUp()
    {
        pickup_icon.SetActive(false);
    }


}