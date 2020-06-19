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
    private float timer;
    private GameObject obj;
    public float wanderRadius;
    public float wanderTimer;
    public int maskct = 0, kolnct = 0;

    private Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
         newPos = RandomNavSphere(transform.position, wanderRadius, -1);
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       /* if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
           
            agent.SetDestination(newPos);
            timer = 0;
        }*/
       
       agent.SetDestination(newPos);
       if(agent.remainingDistance<=2)
            newPos = RandomNavSphere(transform.position, wanderRadius, -1);
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        
        return navHit.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Citizen")
        {
            foreach (Transform child in other.gameObject.transform)
                if (child.CompareTag("Virus"))
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