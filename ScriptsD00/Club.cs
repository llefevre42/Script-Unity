using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {
	private int hit = 0;
	public GameObject balle;
	public GameObject club;
	private int reverse = 0;
	private float prePos;
	private float postPos;

	void	Start()
	{
		prePos = balle.transform.position.y;
		postPos = 0;
	}

	void Update ()
	{
		if(Input.GetKey("space") && balle != null && balle.transform.position.z > -30)
		{
			if(reverse == 0)
				transform.Translate(new Vector3(0, -0.1f, 0));
			else
				transform.Translate(new Vector3(0, 0.1f, 0));
			hit = 1;
		}
		else if(hit == 1 && balle != null && balle.transform.position.z > -30)
		{
			hit = 0;
		}
		else if(balle != null && balle.transform.position.z > -30)
		{
			if(postPos == prePos && balle.transform.position.z > -30)
			{
				if(reverse == 1)
				{
					club.transform.position = new Vector3(club.transform.position.x, balle.transform.position.y + 1.5f, -11);
				}
				else
				{
					club.transform.position = new Vector3(club.transform.position.x, balle.transform.position.y, -11);
				}
			}
			else
			{
				postPos = prePos;
			}
			hit = 2;
		}
		if(balle != null && balle.transform.position.y > 4 && balle.transform.position.z > -30)
		{
			reverse = 1;
		}
		if(balle != null && balle.transform.position.y < -4 && balle.transform.position.z > -30)
		{
			reverse = 0;
		}
		if(balle != null && balle.transform.position.z > -30)
		{
			prePos = balle.transform.position.y;
		}
	}
}
