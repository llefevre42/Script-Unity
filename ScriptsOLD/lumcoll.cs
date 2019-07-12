using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumcoll : MonoBehaviour {
	public GameObject red;
	public GameObject vacum;
	private int isIn = 0;
	public float power;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update () {

		if((vacum) && vacum.GetComponent<Vacum>().onOff == 1)
		{
			power = 1;
		}
		if(isIn == 1)
			red.GetComponent<stressBar>().stress += power;
	}

	void OnTriggerEnter(Collider collision)
	 {
			 if(collision.gameObject.name == "Main Camera")
			 	isIn = 1;
	 }

	 void OnTriggerExit(Collider collision)
 	 {
 			 if(collision.gameObject.name == "Main Camera")
 			 	isIn = 0;
 	 }
}
