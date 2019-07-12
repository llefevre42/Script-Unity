using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject balle;
	private float speed = 0;
	private int load = 0;
	private int reverse = 0;
	private int score = -15;
	private int hit = 0;

	void Update ()
	{
		if(speed > 0 && load == 0 && balle.transform.position.z > -30)
		{
			if(reverse == 1)
				transform.Translate(new Vector3(0, -speed, 0));
			else
				transform.Translate(new Vector3(0, speed, 0));

			speed -= 0.1f;
		}
		else
		{
			if(Input.GetKey("space") && balle.transform.position.z > -30 )
			{
				load = 1;
				speed += 0.1f;
			}
			else if(load == 1)
			{
				hit = 1;
				load = 0;
			}
		}
		if(balle.transform.position.y > 4 && balle.transform.position.z > -30)
		{
			reverse = 1;
		}
		if(balle.transform.position.y < -4 && balle.transform.position.z > -30)
		{
			reverse = 0;
		}
		if(balle.transform.position.y >= 2.9 && balle.transform.position.y <= 3.16 && speed < 0.3 && balle.transform.position.z > -30)
		{
			balle.transform.position = new Vector3(0, 3, -100);
		}
		else if(hit == 1 && balle.transform.position.z > -30)
		{
			score += 5;
			Debug.Log("score: " + score);
			hit = 0;
		}

	}
}
