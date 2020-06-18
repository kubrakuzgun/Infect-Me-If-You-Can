using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealer : MonoBehaviour
{
    public GameObject immunebooster;
    public GameObject player;
    public GameObject fpscontroller;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (immunebooster.tag == "KellePaca" && fpscontroller.GetComponent<InventoryController>().kellepaca>0)
            {
                fpscontroller.GetComponent<InventoryController>().kellepaca--;

                if (player.GetComponent<PlayerHealth>().health + 25 <= 100)
                {
                    player.GetComponent<PlayerHealth>().health += 25;
                }
                else
                    player.GetComponent<PlayerHealth>().health = 100;

                Debug.LogWarning("Canan Karatay was here!");

            }


            else if (immunebooster.tag == "Sıcvepis" && fpscontroller.GetComponent<InventoryController>().sicvepis > 0)
            {
                fpscontroller.GetComponent<InventoryController>().sicvepis--;

                if (player.GetComponent<PlayerHealth>().health + 10 <= 100)
                {
                    player.GetComponent<PlayerHealth>().health += 10;
                }
                else
                    player.GetComponent<PlayerHealth>().health = 100;

                Debug.LogWarning("SIÇVEPİSSSS!");

            }
        }
    }
}
