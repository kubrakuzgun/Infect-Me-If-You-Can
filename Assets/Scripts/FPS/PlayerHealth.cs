using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health=100;
    public GameObject gameover_panel, music;
    // Start is called before the first frame update
    void Start()
    {
        gameover_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.LogWarning("CoffinDance.mp3");
            gameover_panel.SetActive(true);
            music.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Citizen")
        {
            if (other.GetComponent<InfectedPeopleHealer>().infected == true)
            {
                if (health > 25)
                {
                    health -= 25;
                    if (health <= 10)
                    {
                        Debug.LogWarning("KORONOOOO!");
                    }
                }
                else
                {
                    health = 0;
                }
            }

        }

        if (other.tag == "StandingCitizen")
        {
            if (other.GetComponent<StandingPeopleHealer>().infected == true)
            {
                if (health > 25)
                {
                    health -= 25;
                    if (health <= 10)
                    {
                        Debug.LogWarning("KORONOOOO!");
                    }
                }
                else
                {
                    health = 0;
                }
            }
        }



        if (other.tag == "SurfaceVirus")
        {
            if (health - 5 >= 0)
            {
                health -= 5;
                if (health <= 10)
                {
                    Debug.LogWarning("KORONALANDIN!");
                }
            }
            else
            {
                health = 0;
            }
        }

    }
}
