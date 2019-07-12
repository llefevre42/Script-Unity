using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour {
	public GameObject hitBox;
	public GameObject Player;
	// Use this for initialization
	void Start ()
	{

	}
	// Update is called once per frame
	void Update ()
	{

	}
	void OnTriggerEnter2D(Collider2D col)
 {
	 if(col.name == Player.name)
	 	hitBox.GetComponent<Text>().text = 1 + "";
 }
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.name == Player.name)
			hitBox.GetComponent<Text>().text = 0 + "";
	}

}
