using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health=100;
    public GameObject gameover_panel, music, wastedsound, wastedpanel;
    public bool infected=false;
    // Start is called before the first frame update
    void Start()
    {
        gameover_panel.SetActive(false);
        wastedpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            this.gameObject.GetComponent<FirstPersonAIO>().enableCameraMovement = false;
            this.gameObject.GetComponent<FirstPersonAIO>().playerCanMove = false;
            this.gameObject.GetComponent<FirstPersonAIO>().autoCrosshair = false;
            wastedpanel.SetActive(true);
            wastedsound.SetActive(true);
            StartCoroutine(WaitSec());
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
                        infected = true;
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
                        infected = true;
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
                    infected = true;
                }
            }
            else
            {
                health = 0;
            }
        }

    }

    public IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(3f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        wastedpanel.SetActive(false);
        gameover_panel.SetActive(true);
        music.SetActive(true);
    }
}
