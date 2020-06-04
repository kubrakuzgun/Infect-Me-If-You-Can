using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AnonsController : MonoBehaviour
{
    int count;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && count<1)
        {
            audiosource.Play();
            count++;
        }

    }
}
