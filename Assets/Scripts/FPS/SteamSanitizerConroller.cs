using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamSanitizerConroller : MonoBehaviour
{
    public GameObject steam;
    // Start is called before the first frame update
    void Start()
    {
        steam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            steam.SetActive(true);
        }        
        else if (Input.GetMouseButtonUp(0))
        {
            steam.SetActive(false);
        }
    }
}
