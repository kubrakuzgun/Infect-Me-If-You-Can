using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidSanitizerConroller : MonoBehaviour
{
    public GameObject liquid;

    // Start is called before the first frame update
    void Start()
    {
        liquid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            liquid.SetActive(true);
        }
        else 
        {
            liquid.SetActive(false);
        }
    }
}

