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
                if (health < 1)
                {
                    Debug.Log("KORONALANDIN!");
                }
            }

        }


        if (other.tag == "KellePaca")
        {
            if (health + 25 <= 100)
            {
                health += 25;
            }

            Destroy(other.gameObject);
        }

        else if (other.tag == "Sıcvepis")
        {
            if (health+10 <= 100)
            {
                health += 10;
            }
        }

    }
}
