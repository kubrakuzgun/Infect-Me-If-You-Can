using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPeopleHealer : MonoBehaviour
{
    public GameObject virus;
    public GameObject mask;
    private GameObject obj;
    public int health;
    public int maskct = 0, kolnct = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Citizen")
        {
            foreach (Transform child in other.gameObject.transform) if (child.CompareTag("Virus"))
                {
                    obj = child.gameObject;
                }


            if (obj.activeInHierarchy == true)
            {
                if (health > 50)
                {
                    health -= 50;
                    if (health < 20)
                    {
                        virus.SetActive(true);
                    }
                }
                else
                {
                    health = 0;
                    virus.SetActive(true);
                }

            }

        }

        if (other.tag == "SurfaceVirus")
        {
            if (health - 25 >= 0)
            {
                health -= 25;
                if (health < 20)
                {
                    virus.SetActive(true);
                }
            }
            else
            {
                health = 0;
                virus.SetActive(true);
            }
        }

        if (other.tag == "Syringe")
        {

            if (health + 25 <= 100)
            {
                health += 25;

                if (health >= 100)
                {
                    virus.SetActive(false);
                }
            }
            else
            {
                health = 100;
                virus.SetActive(false);
            }

            Destroy(other.gameObject);
        }

        else if (other.tag == "Pill")
        {
            if (health + 15 <= 100)
            {
                health += 10;

                if (health >= 100)
                {
                    virus.SetActive(false);
                }
            }

            else
            {
                health = 100;
                virus.SetActive(false);
            }

            Destroy(other.gameObject);
        }

        else if (other.tag == "Mask" && maskct < 1)
        {
            maskct++;
            mask.SetActive(true);

            if (health + 5 <= 100)
            {
                health += 5;

                if (health >= 100)
                {
                    virus.SetActive(false);
                }
            }

            else
            {
                health = 100;
                virus.SetActive(false);
            }

            Destroy(other.gameObject);
        }

        else if (other.tag == "Kolonya" && kolnct < 2)
        {
            kolnct++;

            if (health + 5 <= 100)
            {
                health += 5;

                if (health >= 100)
                {
                    virus.SetActive(false);
                }
            }

            else
            {
                health = 100;
                virus.SetActive(false);
            }

            Destroy(other.gameObject);
        }

    }
}
