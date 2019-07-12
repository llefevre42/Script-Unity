using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
	public GameObject pipe;
	public float y;
	private float speed = 0.1f;
	void Update ()
	{
		transform.Translate(new Vector3(-speed, 0, 0));
		if(pipe.transform.position.x < -10)
		{
			speed+= 0.01f;
			pipe.transform.position = new Vector3(10 , y , 0);
		}
	}
}
