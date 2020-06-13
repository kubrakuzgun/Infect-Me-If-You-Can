using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
	public GameObject syringegun, medgun, lqsanitizer, stsanitizer;
	public GameObject syraim, medaim, lqaim, staim;
	Boolean medactive, syractive, lqactive, stactive;

	public static PlayerController instance;
	// Start is called before the first frame update
	void Start()
	{

		syractive = true;
		medactive = false;
		lqactive = false;
		stactive = false;
		medgun.SetActive(false);
		syraim.SetActive(false);
		medaim.SetActive(false);
		lqsanitizer.SetActive(false);
		stsanitizer.SetActive(false);		
		lqaim.SetActive(false);
		staim.SetActive(false);
		


	}


	// Update is called once per frame
	void Update()
	{

		if (syractive == false && Input.GetKeyDown(KeyCode.Alpha1))
		{


			syringegun.SetActive(true);
			syractive = true;

			medgun.SetActive(false);
			lqsanitizer.SetActive(false);
			stsanitizer.SetActive(false);

			medactive = false;
			lqactive = false;
			stactive = false;


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

		}



		if (Input.GetMouseButton(1))
		{

			if (medactive == true)
			{
				medaim.SetActive(true);
				medgun.SetActive(false);

			}

			else if (syractive == true)
			{
				syraim.SetActive(true);
				syringegun.SetActive(false);

			}			
			
			else if (lqactive == true)
			{
				lqaim.SetActive(true);
				lqsanitizer.SetActive(false);

			}			
			
			else if (stactive == true)
			{
				staim.SetActive(true);
				stsanitizer.SetActive(false);

			}


		}

		else
		{
			if (medactive == true)
			{
				medgun.SetActive(true);
				medaim.SetActive(false);

			}

			else if (syractive == true)
			{
				syringegun.SetActive(true);
				syraim.SetActive(false);
			}


			else if (lqactive == true)
			{
				lqsanitizer.SetActive(true);
				lqaim.SetActive(false);

			}		
			
			else if (stactive == true)
			{
				stsanitizer.SetActive(true);
				staim.SetActive(false);

			}

		}

	}
}
