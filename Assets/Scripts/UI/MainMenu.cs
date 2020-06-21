using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("fullscreen", 1)
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
