using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public float newVolume;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        newVolume = this.GetComponent<Slider>().value;

        PlayerPrefs.SetFloat("volume", newVolume);

    }
    
}
