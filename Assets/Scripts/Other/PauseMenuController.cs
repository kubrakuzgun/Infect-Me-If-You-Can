using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PauseMenuController : MonoBehaviour
{

    public static bool gameIsPaused=false;
    public GameObject pausemenu_ui;

    void Start()
    {
        pausemenu_ui.SetActive(false);
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
    
    void ResumeGame()
    {
        pausemenu_ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}
