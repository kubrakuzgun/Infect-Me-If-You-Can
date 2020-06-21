using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InfectedPeopleHealer : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject virus;
    public GameObject mask;
    public int health;
    private GameObject obj;
    public int maskct = 0, kolnct = 0;
    public bool infected;
    
    [Tooltip("How far ahead of the current position to look ahead for a wander")]
    public float wanderDistance = 20;
    [Tooltip("The amount that the agent rotates direction")]
    public float wanderRate = 2;

    public void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Start()
    {
        agent.enabled = true;
        agent.destination = Target();
    }

    void Update()
    {
        agent.destination = Target();
        if (virus.activeInHierarchy)
        {
            infected = true;
        }
        else if (!virus.activeInHierarchy)
        {
            infected = false;
        }
    }
    
    private Vector3 Target()
    {
        var direction = transform.forward + Random.insideUnitSphere * wanderRate;
        return transform.position + direction.normalized * wanderDistance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Citizen")
        {
          /*  foreach (Transform child in other.gameObject.transform)
                if (child.CompareTag("Virus"))
                {
                    obj = child.gameObject;
                } */

            if (other.GetComponent<InfectedPeopleHealer>().infected == true)
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

        if (other.tag == "StandingCitizen")
        {
          

            if (other.GetComponent<StandingPeopleHealer>().infected == true)
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

        else if (other.tag == "MaskHeal" && maskct < 1)
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

        else if (other.tag == "KolonyaHeal" && kolnct < 2)
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