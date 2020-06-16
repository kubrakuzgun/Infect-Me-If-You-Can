using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InfectedPeopleHealer : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject virus;
    public int health;
    private float timer;
    
    public float wanderRadius;
    public float wanderTimer;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }

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

        if (other.tag == "Syringe")
        {
            health += 25;

            if (health >= 100)
            {
                virus.SetActive(false);
            }
        }
        
        else if (other.tag == "Pill")
        {
            health += 10;

            if (health >= 100)
            {
                virus.SetActive(false);
            }
        }


    }



}
