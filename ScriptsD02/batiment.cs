using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batiment : MonoBehaviour {
	public int hp = 100;
	public GameObject bat;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(hp == 0)
			GameObject.Destroy(bat);
	}
}
