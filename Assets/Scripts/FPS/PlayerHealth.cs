using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health=100;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.LogWarning("CoffinDance.mp3");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Citizen")
        {
            if (other.GetComponent<InfectedPeopleHealer>().infected == true)
            {
                if (health > 30)
                {
                    health -= 30;
                    if (health <= 10)
                    {
                        Debug.LogWarning("KORONOOOO!");
                    }
                }
            }
            else
            {
                health = 0;
            }

        }

        if (other.tag == "StandingCitizen")
        {
            if (other.GetComponent<StandingPeopleHealer>().infected == true)
            {
                if (health > 30)
                {
                    health -= 30;
                    if (health <= 10)
                    {
                        Debug.LogWarning("KORONOOOO!");
                    }
                }
            }
            else
            {
                health = 0;
            }

        }



        if (other.tag == "SurfaceVirus")
        {
            if (health - 10 >= 0)
            {
                health -= 10;
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
