using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1);
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarHandler.SetHealthBarValue(player.GetComponent<PlayerHealth>().health/100.0f);
        if (player.GetComponent<PlayerHealth>().health <= 10)
        {
            HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.001f);
        }
    }
}
