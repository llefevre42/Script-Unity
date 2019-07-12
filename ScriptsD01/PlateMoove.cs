using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateMoove : MonoBehaviour {

	public GameObject plate;
	public float speed;
	public float dist;
	private int dir;
	private float start;
	public bool vertical;
	// Use this for initialization
	void Start ()
	{
		if(vertical)
				start = plate.transform.position.y;
		else
				start = plate.transform.position.x;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if(vertical)
		{
			if(plate.transform.position.y > start + dist)
			{
					dir = 1;
			}
			else if(plate.transform.position.y < start - dist)
				dir = 0;
			if(dir == 1)
			{
				transform.Translate(new Vector3(0 ,-1 ,0) * speed *  Time.deltaTime);
			}
			else
				transform.Translate(new Vector3(0 ,1 ,0) * speed *  Time.deltaTime);
		}
		else
		{
			if(plate.transform.position.x > start + dist)
			{
					dir = 1;
			}
			else if(plate.transform.position.x < start - dist)
				dir = 0;
			if(dir == 1)
			{
				transform.Translate(new Vector3(-1 ,0 ,0) * speed *  Time.deltaTime);
			}
			else
				transform.Translate(new Vector3(1 ,0 ,0) * speed *  Time.deltaTime);
		}
	}
}
