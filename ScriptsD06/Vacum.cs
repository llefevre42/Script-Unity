using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacum : MonoBehaviour {
	public ParticleSystem fume;
	public int onOff = 0;
	private int nevercall;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision)
	 {
			 if(collision.gameObject.name == "Main Camera" && nevercall == 0)
			 {
				nevercall = 1;
			 	fume.Play();
				onOff = 1;
			}
	 }
}
