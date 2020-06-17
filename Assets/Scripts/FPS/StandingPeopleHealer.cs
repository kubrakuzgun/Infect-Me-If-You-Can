using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingPeopleHealer : MonoBehaviour
{
    public GameObject virus;
    private GameObject obj;
    public int health;
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
                health -= 50;
                if (health < 50)
                {
                    virus.SetActive(true);
                }
            }

        }


        if (other.tag == "Syringe")
        {
            health += 25;

            if (health >= 100)
            {
                virus.SetActive(false);
            }

            Destroy(other.gameObject);
        }

        else if (other.tag == "Pill")
        {
            health += 10;

            if (health >= 100)
            {
                virus.SetActive(false);
            }
            Destroy(other.gameObject);
        }


    }
}
