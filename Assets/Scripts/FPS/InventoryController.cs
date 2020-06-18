using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WeaponWheel;

public class InventoryController : MonoBehaviour
{
    public GameObject pickup_icon, player;
    public GameObject syrgun, medgun, lqgun, stgun;
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
            kapsul+=10;
            syrgun.GetComponent<Weapon>().ClipSize += kapsul;
            syrgun.GetComponent<Weapon>().ammo += kapsul;
            syrgun.GetComponent<Weapon>().ammoInUse += kapsul;
            syrgun.GetComponent<Weapon>().noammo =false;
            other.gameObject.SetActive(false);
            
        }

        if (other.tag == "Medicine" && Input.GetKeyDown(KeyCode.E))
        {
            ilac+=20;
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
            steam+=30;
            stgun.GetComponent<Weapon>().ClipSize += steam;
            stgun.GetComponent<Weapon>().ammo += steam;
            stgun.GetComponent<Weapon>().ammoInUse += steam;
            stgun.GetComponent<Weapon>().noammo = false;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Kolonya" && Input.GetKeyDown(KeyCode.E))
        {
            kolonya++;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "MaskPack" && Input.GetKeyDown(KeyCode.E))
        {
            maske+=10;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "Sicvepis" && Input.GetKeyDown(KeyCode.E))
        {
            sicvepis++;
            other.gameObject.SetActive(false);
        }

        if (other.tag == "KellePaca" && Input.GetKeyDown(KeyCode.E))
        {
            kellepaca++;
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