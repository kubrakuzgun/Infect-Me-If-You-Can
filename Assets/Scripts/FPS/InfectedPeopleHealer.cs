using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedPeopleHealer : MonoBehaviour
{
    Animator walkanim;
    public GameObject virus;
    public int health;
    public float walkspeed;
    bool walkenabled;

    // Start is called before the first frame update
    void Start()
    {
        walkanim = GetComponent<Animator>();
        walkenabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (walkenabled == true)
        {
            walkanim.Play("Take 001");
            transform.Translate(Vector3.forward * walkspeed);
        }
        else
            walkanim.Play("Wait");


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Syringe")
        {
            walkenabled = false;
            health += 25;

            if (health >= 100)
            {
                WaitForSeconds seconds = new WaitForSeconds(5);
                virus.SetActive(false);

                walkanim.Play("LongWait");

                walkenabled = true;
            }
        }


    }



}
