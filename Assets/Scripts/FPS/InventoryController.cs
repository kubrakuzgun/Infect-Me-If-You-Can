using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject pickup_icon, player;
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
        if (other.tag == "Kapsul")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                kapsul++;
                other.gameObject.SetActive(false);
            }

        }

        if (other.tag == "Medicine")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                ilac++;
                other.gameObject.SetActive(false);
            }
        }

        if (other.tag == "Borel")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                borel++;
                other.gameObject.SetActive(false);
            }
        }  
        
        if (other.tag == "Steam")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                steam++;
                other.gameObject.SetActive(false);
            }
        }        
        
        if (other.tag == "Kolonya")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                kolonya++;
                other.gameObject.SetActive(false);
            }
        } 

        if (other.tag == "MaskPack")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                maske+=5;
                other.gameObject.SetActive(false);
            }
        }        
        
        if (other.tag == "Sicvepis")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                sicvepis++;
                other.gameObject.SetActive(false);
            }
        }
                
        if (other.tag == "KellePaca")
        {
            pickup_icon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                kellepaca++;
                other.gameObject.SetActive(false);
            }
        }
        


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Kapsul" || other.tag == "Medicine" || other.tag == "Borel" || other.tag == "Steam" || other.tag == "Kolonya" || other.tag == "MaskPack" || other.tag == "Sicvepis" || other.tag == "KellePaca")
        {
            pickup_icon.SetActive(false);
        }
    }
}