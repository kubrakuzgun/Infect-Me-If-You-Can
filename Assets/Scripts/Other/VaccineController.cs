using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineController : MonoBehaviour
{
    public GameObject e_icon, boxclosed, boxopen, gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        boxclosed.SetActive(true);
        boxopen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            e_icon.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                boxclosed.SetActive(false);
                boxopen.SetActive(true);
                StartCoroutine(WaitSec());
            }

        }
    }

    public IEnumerator WaitSec()
    {
        e_icon.SetActive(false);
        yield return new WaitForSeconds(3f);
        gamemanager.GetComponent<MissionController>().foundvaccine = 1;
    }
}
