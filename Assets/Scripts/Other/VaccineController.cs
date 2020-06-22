using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineController : MonoBehaviour
{
    public GameObject e_icon, boxclosed, boxopen, gamemanager;
    private bool trigerred, gamefinished=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamefinished)
        {
            StartCoroutine(WaitSec());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            e_icon.SetActive(true);

            trigerred = true;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (trigerred)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                boxclosed.SetActive(false);
                boxopen.SetActive(true);
                gamefinished = true;
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
