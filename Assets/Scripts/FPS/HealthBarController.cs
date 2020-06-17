using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(100);
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarHandler.SetHealthBarValue(player.GetComponent<PlayerHealth>().health);
    }
}
