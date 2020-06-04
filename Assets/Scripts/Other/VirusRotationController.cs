using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusRotationController : MonoBehaviour
{
    public float speedslower;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {

        if(rand == 1)
        {
            transform.RotateAround(transform.position, Vector3.right, 360f * Time.deltaTime / speedslower);

        }
        else if(rand == 2)
        {
            transform.RotateAround(transform.position, Vector3.up, 360f * Time.deltaTime / speedslower);

        }
    }
}
