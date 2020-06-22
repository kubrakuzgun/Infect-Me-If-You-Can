using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    public Text numbers1, numbers2, numbers3, numbers4, numbers3_2;
    public GameObject greenpanel, winpanel, hiddenvaccinebox;
    public GameObject mission1, mission2, mission3, mission4;
    public bool mission1done, mission2done, mission3done, mission4done;
    public int healedpeople=0, cleanedsurface=0, givenmask=0, givenkolonya=0, foundvaccine=0;

    // Start is called before the first frame update
    void Start()
    {
        mission1.SetActive(true);
        mission2.SetActive(false);
        mission3.SetActive(false);
        mission4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        numbers1.text = healedpeople.ToString() + "/10";
        numbers2.text = cleanedsurface.ToString() + "/9";
        numbers3.text = givenmask.ToString() + "/10";
        numbers3_2.text = givenkolonya.ToString() + "/10";
        numbers4.text = foundvaccine.ToString() + "/1";
        
        if (healedpeople >= 10)
        {
            mission1done = true;
            mission1.SetActive(false);
            mission2.SetActive(true);
        }        
        
        if (cleanedsurface >= 9)
        {
            mission2done = true;
            mission2.SetActive(false);
            mission3.SetActive(true);
        }    
        
        if (givenmask >= 10 && givenkolonya >= 10)
        {
            mission3done = true;
            mission3.SetActive(false);
            mission4.SetActive(true);
        }        

        if(mission1done && mission2done && mission3done)
        {
            hiddenvaccinebox.SetActive(true);
        }

        if (foundvaccine == 1)
        {
            mission4done = true;
            greenpanel.SetActive(true);
            StartCoroutine(WaitSec());
            Time.timeScale = 0f;
        }

    }

    public IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(2f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        greenpanel.SetActive(false);
        winpanel.SetActive(true);
    }
}
