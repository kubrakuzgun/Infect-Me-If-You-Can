using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFullscreen : MonoBehaviour
{
    public bool newtoggle=true;
    public int toggleval = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("fullscreen") == 1)
        {
            newtoggle = true;
        }
        else newtoggle = false;

        this.gameObject.GetComponent<Toggle>().isOn = newtoggle;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.GetComponent<Toggle>().isOn)
        {
            toggleval = 1;
            Screen.fullScreen = true;
            PlayerPrefs.SetInt("fullscreen", toggleval);


        }
        else
        {
            toggleval = 0;
            Screen.fullScreen = false;
            PlayerPrefs.SetInt("fullscreen", toggleval);
        }
    }

    public void SetFullScreen()
    {
        PlayerPrefs.SetInt("fullscreen", toggleval);
    }
}
