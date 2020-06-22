using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public bool aimactive = false;
    public GameObject syringegun, medgun, lqsanitizer, stsanitizer;
    public GameObject syraim, medaim, lqaim, staim;
    public Boolean medactive, syractive, lqactive, stactive;

    public GameObject maske, kolonya;
    public GameObject maskeaim, kolonyaaim;

    public GameObject scw, kellep;
    public GameObject heal_icon;
    public GameObject e_icon;
    public Boolean maskeactive, kolonyaactive, scwactive, kellepactive;

    public static PlayerController instance;

    void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        syractive = true;
        medactive = false;
        lqactive = false;
        stactive = false;
        maskeactive = false;
        kolonyaactive = false;
        scwactive = false;
        kellepactive = false;
        medgun.SetActive(false);
        syraim.SetActive(false);
        medaim.SetActive(false);
        lqsanitizer.SetActive(false);
        stsanitizer.SetActive(false);
        lqaim.SetActive(false);
        staim.SetActive(false);
        maske.SetActive(false);
        kolonya.SetActive(false);
        scw.SetActive(false);
        kellep.SetActive(false);
    }

    public void SelectWeapon(int weapon)
    {
        e_icon.SetActive(false);

        if (syractive == false && weapon == 1)
        {
            syringegun.SetActive(true);
            syractive = true;

            medgun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);

            medactive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }

        if (medactive == false && weapon == 2)
        {
            medgun.SetActive(true);
            medactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);

            syractive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }

        if (lqactive == false && weapon == 3)
        {
            lqsanitizer.SetActive(true);
            lqactive = true;

            syringegun.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);

            syractive = false;
            medactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }


        if (stactive == false && weapon == 4)
        {
            stsanitizer.SetActive(true);
            stactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            medgun.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);

            syractive = false;
            medactive = false;
            lqactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }        
        

        if (maskeactive == false && weapon == 5)
        {
            maske.SetActive(true);
            maskeactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);


            syractive = false;
            medactive = false;
            lqactive = false;
            stactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }        
        

        if (kolonyaactive == false && weapon == 6)
        {
            kolonya.SetActive(true);
            kolonyaactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);
            maske.SetActive(false);
            scw.SetActive(false);
            kellep.SetActive(false);


            syractive = false;
            medactive = false;
            stactive = false;
            lqactive = false;
            maskeactive = false;
            scwactive = false;
            kellepactive = false;
        }        
        
        if (scwactive == false && weapon == 7)
        {
            scw.SetActive(true);
            scwactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            kellep.SetActive(false);


            syractive = false;
            medactive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            kellepactive = false;
        }  
        
        
        if (kellepactive == false && weapon == 8)
        {
            kellep.SetActive(true);
            kellepactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);
            maske.SetActive(false);
            kolonya.SetActive(false);
            scw.SetActive(false);


            syractive = false;
            medactive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
      /*  if (syractive == false && Input.GetKeyDown(KeyCode.Alpha1))
        {
            syringegun.SetActive(true);
            syractive = true;

            medgun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);

            medactive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }

        if (medactive == false && Input.GetKeyDown(KeyCode.Alpha2))
        {
            medgun.SetActive(true);
            medactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            stsanitizer.SetActive(false);

            syractive = false;
            lqactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }

        if (lqactive == false && Input.GetKeyDown(KeyCode.Alpha3))
        {
            lqsanitizer.SetActive(true);
            lqactive = true;

            syringegun.SetActive(false);
            stsanitizer.SetActive(false);
            medgun.SetActive(false);

            syractive = false;
            medactive = false;
            stactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        }


        if (stactive == false && Input.GetKeyDown(KeyCode.Alpha4))
        {
            stsanitizer.SetActive(true);
            stactive = true;

            syringegun.SetActive(false);
            lqsanitizer.SetActive(false);
            medgun.SetActive(false);

            syractive = false;
            medactive = false;
            lqactive = false;
            maskeactive = false;
            kolonyaactive = false;
            scwactive = false;
            kellepactive = false;
        } */


        if (Input.GetMouseButton(1))
        {
            e_icon.SetActive(false);

            if (medactive == true)
            {
                medaim.SetActive(true);
                medgun.SetActive(false);
                aimactive = true;
            }

            else if (syractive == true)
            {
                syraim.SetActive(true);
                syringegun.SetActive(false);
                aimactive = true;
            }

            else if (lqactive == true)
            {
                lqaim.SetActive(true);
                lqsanitizer.SetActive(false);
                aimactive = true;
            }

            else if (stactive == true)
            {
                staim.SetActive(true);
                stsanitizer.SetActive(false);
                aimactive = true;
            }            
            
            else if (maskeactive == true)
            {
                maskeaim.SetActive(true);
                maske.SetActive(false);
                aimactive = true;
            }        
            
            else if (kolonyaactive == true)
            {
                kolonyaaim.SetActive(true);
                kolonya.SetActive(false);
                aimactive = true;
            }
        }

        else
        {
            if (medactive == true)
            {
                medgun.SetActive(true);
                medaim.SetActive(false);
                aimactive = false;
            }

            else if (syractive == true)
            {
                syringegun.SetActive(true);
                syraim.SetActive(false);
                aimactive = false;
            }


            else if (lqactive == true)
            {
                lqsanitizer.SetActive(true);
                lqaim.SetActive(false);
                aimactive = false;
            }

            else if (stactive == true)
            {
                stsanitizer.SetActive(true);
                staim.SetActive(false);
                aimactive = false;
            }            
            
            else if (maskeactive == true)
            {
                maske.SetActive(true);
                maskeaim.SetActive(false);
                aimactive = false;
            }           
            
            else if (kolonyaactive == true)
            {
                kolonya.SetActive(true);
                kolonyaaim.SetActive(false);
                aimactive = false;
            }
        }


        if (!scwactive)
        {
            heal_icon.SetActive(false); 
        }

        if (!kellepactive)
        {
            heal_icon.SetActive(false); 
        }


    }
}