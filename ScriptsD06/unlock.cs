using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour {
	public GameObject barel;
	public GameObject door;
	public AudioSource audi;
	private int nevercall;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision)
	 {
			 if(collision.gameObject.name == "Main Camera" && barel.GetComponent<Clef>().clefRecup == 1 && nevercall == 0)
			 {
				 nevercall = 1;
				 audi.Play();
				GameObject.Destroy(door);
			}
	 }
}
