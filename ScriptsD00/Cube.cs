using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	public GameObject obj;
	private float speed;
	// Use this for initialization
	void Start () {
		speed = Random.Range(0.1f, 0.5f);
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate(new Vector3(0, -speed, 0));
		if(obj.transform.position.y < -10)
			GameObject.Destroy(obj);
	}
}
