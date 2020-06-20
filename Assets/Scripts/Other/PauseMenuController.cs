using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{

    public static bool gameIsPaused=false;
    public GameObject pausemenu_ui, options_menu;
    public Slider slider;

    void Start()
    {
        pausemenu_ui.SetActive(false);
        options_menu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
                PauseGame();
        }
    }

    void PauseGame()
    {
        gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
       
        pausemenu_ui.SetActive(true);

    }    
    
    public void ResumeGame()
    {
        pausemenu_ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene("LoadingScreen");
    }

    public void OpenOptionsMenu()
    {
        options_menu.SetActive(true);
    }

    public void BackToPauseMenu()
    {
        options_menu.SetActive(false);
    }
    public void SetVolume()
    {
        PlayerPrefs.SetFloat("volume", slider.GetComponent<ChangeVolume>().newVolume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
        Debug.LogWarning("Volume changed...");
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene("Main Menu");
    }    

    public void QuitGame()
    {
        Debug.LogWarning("Quitting game...");
        Application.Quit();
    }

}
