using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurfaceVirusCleaner : MonoBehaviour
{
    public int strength;
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
            if (strength - 10 >= 0)
            {
                strength -= 10;
                if (strength <= 0)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                strength = 0;
                Destroy(this.gameObject);
            }
        }      
        if (other.tag == "SteamSanitizer")
        {
            if (strength - 20 >= 0)
            {
                strength -= 20;
                if (strength <= 0)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                strength = 0;
                Destroy(this.gameObject);
            }
        }

    }

}
