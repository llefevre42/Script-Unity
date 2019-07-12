using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonColor : MonoBehaviour {

	public Collider2D plateform;
	public GameObject player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}/*
	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log(col.gameObject.name);
		Debug.Log(player.name);
	 	if(col.gameObject.name != player.name)
	 	{
			plateform.isTrigger = true;
	 	}

	}
	 void OnCollisionExit2D(Collision2D col)
	 {
		if(col.gameObject.name != player.name)
		{
		 plateform.isTrigger = false;
		}
	}*/
}
