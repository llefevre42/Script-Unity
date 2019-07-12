using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonEnemy : MonoBehaviour {
	public GameObject corp;
	public GameObject canonT;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
			canonT.transform.position = new Vector3(corp.transform.position.x, corp.transform.position.y + 1.5f, corp.transform.position.z);
	}
}
