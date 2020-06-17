using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PauseMenuController : MonoBehaviour
{

    private static bool gameIsPaused;
    public GameObject pausemenu_ui;

    void Start()
    {
        pausemenu_ui.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pausemenu_ui.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausemenu_ui.SetActive(false);
        }
    }
}
