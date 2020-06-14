using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeHeal : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject infectedPerson;
    public float radius = 1.0F;
    public int healamount;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {


            if (hit.CompareTag("Infected"))
            {

            }

        }
        Destroy(this.gameObject);
    }


}
