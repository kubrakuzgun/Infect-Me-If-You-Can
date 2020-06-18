using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public GameObject pickup_icon, player;
    public int kolonya, maske, ilac, kapsul, sicvepis, kellepaca, borel, steam;
    bool picked=false;
    // Start is called before the first frame update
    void Start()
    {
        pickup_icon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (picked)
        {
            pickup_icon.SetActive(false);
        }
        
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
        pickup_icon.SetActive(true);
        picked = false;
        if (other.tag == "Kapsul" && Input.GetKeyDown(KeyCode.E))
        {
            kapsul+=10;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "Medicine" && Input.GetKeyDown(KeyCode.E))
        {
            ilac+=20;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "Borel" && Input.GetKeyDown(KeyCode.E))
        {
            borel+=10;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "Steam" && Input.GetKeyDown(KeyCode.E))
        {
            steam+=30;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "Kolonya" && Input.GetKeyDown(KeyCode.E))
        {
            kolonya++;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "MaskPack" && Input.GetKeyDown(KeyCode.E))
        {
            maske+=10;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "Sicvepis" && Input.GetKeyDown(KeyCode.E))
        {
            sicvepis++;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (other.tag == "KellePaca" && Input.GetKeyDown(KeyCode.E))
        {
            kellepaca++;
            other.gameObject.SetActive(false);
            picked = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            picked = false;
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