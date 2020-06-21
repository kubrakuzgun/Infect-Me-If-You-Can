using UnityEngine;
using UnityEngine.AI;

public class WanderingAI : MonoBehaviour
{
    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    private Animator animator;

    private float runningTime = 0;

    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (runningTime > 0)
        {
            runningTime -= Time.deltaTime;
        }
        if (runningTime < 0)
        {
            animator.SetBool("isRunning", false);
            runningTime = 0;
            agent.speed = (float) 3.5;
        }
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
        if (other.tag == "Syringe" || other.tag == "Pill")
        {
            runningTime = 10;
            animator.SetBool("isRunning", true);
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            agent.speed = (float) 5.5;
            timer = 0;
        }
    }
}