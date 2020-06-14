using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    private Transform target;

    private NavMeshAgent agent;

    private PlayerController playerController;

    private Animator animator;
    private bool isTriggered = false;
    public GameObject bank;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        target = PlayerController.instance.syraim.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            isTriggered = true;
            if (distance <= agent.stoppingDistance)
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isSitting", false);
                animator.SetBool("isYelling", true);
            }
            else
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isSitting", false);
                animator.SetBool("isYelling", false);
                agent.SetDestination(target.position);
            }
        }
        else
        {
            if (isTriggered)
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isSitting", false);
                animator.SetBool("isYelling", true);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}