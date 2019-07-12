using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	public GameObject Tpin;
	public GameObject Tpout;

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		col.gameObject.transform.position = Tpout.transform.position;
	}
}
