using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject player;
	public KeyCode keyUp;
	public KeyCode keyDown;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(keyUp) && player.transform.position.y < 2.5)
			transform.Translate(new Vector3(0, 0.3f, 0));
		if(Input.GetKey(keyDown) && player.transform.position.y > -2.5)
			transform.Translate(new Vector3(0, -0.3f, 0));
	}
}
