using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMouseSensitivity : MonoBehaviour
{
    public float newsensitivity;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sensitivity");

    }

    // Update is called once per frame
    void Update()
    {
        newsensitivity = this.GetComponent<Slider>().value;

        PlayerPrefs.SetFloat("sensitivity", newsensitivity);

    }
}
