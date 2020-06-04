using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoorController : MonoBehaviour
{
    // Start is called before the first frame update
    Animation anim;
    Animator dooranimator;

    void Start()
    {
          anim = GetComponent<Animation>();
          dooranimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim["Take 001"].speed = 1;
            anim.Play();
        }



    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim["Take 001"].speed = -1;
            anim.Play();
        }


    }

}
