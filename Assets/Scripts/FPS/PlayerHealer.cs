using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealer : MonoBehaviour
{
    public GameObject immunebooster;
    public GameObject fpscontroller;
    public GameObject heal_icon;
    public GameObject kellep, scw;
    
    // Start is called before the first frame update
    void Start()
    {
        heal_icon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(immunebooster.activeInHierarchy && immunebooster.tag == "KellePaca" && fpscontroller.GetComponent<InventoryController>().kellepaca <= 0)
        {
            kellep.SetActive(false);
            heal_icon.SetActive(false);
        }
        else heal_icon.SetActive(true);


        if (immunebooster.activeInHierarchy && immunebooster.tag == "Sıcvepis" && fpscontroller.GetComponent<InventoryController>().sicvepis <= 0)
        {
            scw.SetActive(false);
            heal_icon.SetActive(false);
        }
        else heal_icon.SetActive(true);



        if (Input.GetKeyDown(KeyCode.H))
        {
            if (immunebooster.tag == "KellePaca" && fpscontroller.GetComponent<InventoryController>().kellepaca>0)
            {
                fpscontroller.GetComponent<InventoryController>().kellepaca--;

                if (fpscontroller.GetComponent<PlayerHealth>().health + 25 <= 100)
                {
                    fpscontroller.GetComponent<PlayerHealth>().health += 25;
                }
                else
                    fpscontroller.GetComponent<PlayerHealth>().health = 100;


            }


            else if (immunebooster.tag == "Sıcvepis" && fpscontroller.GetComponent<InventoryController>().sicvepis > 0)
            {
                fpscontroller.GetComponent<InventoryController>().sicvepis--;

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
