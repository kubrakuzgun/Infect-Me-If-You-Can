using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurfaceVirusCleaner : MonoBehaviour
{
    public int strength;
    public GameObject gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LiquidSanitizer")
        {
            if (strength - 20 >= 0)
            {
                strength -= 20;
                if (strength <= 0)
                {
                    Destroy(this.gameObject);
                    gamemanager.GetComponent<MissionController>().cleanedsurface++;
                }
            }
            else
            {
                strength = 0;
                Destroy(this.gameObject);
                gamemanager.GetComponent<MissionController>().cleanedsurface++;
            }
        }      
        if (other.tag == "SteamSanitizer")
        {
            if (strength - 25 >= 0)
            {
                strength -= 25;
                if (strength <= 0)
                {
                    Destroy(this.gameObject);
                    gamemanager.GetComponent<MissionController>().cleanedsurface++;
                }
            }
            else
            {
                strength = 0;
                Destroy(this.gameObject);
                gamemanager.GetComponent<MissionController>().cleanedsurface++;
            }
        }

    }

}
