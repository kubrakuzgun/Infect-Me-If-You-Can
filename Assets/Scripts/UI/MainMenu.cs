﻿using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }   
    
    public void SetVolume()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }    



}
