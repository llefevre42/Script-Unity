using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public GameObject pigeon;
	public GameObject pipe;
	public GameObject pipe2;
	public KeyCode key;
	private int count;
	private int alive = 1;
	public float gravite;
	private int score = 0;
	private int death = 0;
	private int pass = 0;
	// Update is called once per frame
	void Update ()
	{
		if(pigeon.transform.position.y > -3.5 && alive == 1)
			transform.Translate(new Vector3( 0, -gravite, 0));
		if(alive == 0)
			transform.Translate(new Vector3(-0.1f, 0, 0));
		if(Input.GetKeyDown(key) && count == 0)
		{
			count += 10;
		}
		if(count > 0 && alive == 1)
		{
			transform.Translate(new Vector3( 0, 0.4f, 0));
		}
		if(count > 0)
		count--;
		if(pigeon.transform.position.y < -3.5)
			alive = 0;
		if(pigeon.transform.position.y < pipe.transform.position.y - 1.5f && (pipe.transform.position.x < -3.8f && pipe.transform.position.x > -6.4f))
			alive = 0;
		if(pigeon.transform.position.y > pipe.transform.position.y + 1.3f && (pipe.transform.position.x < -3.8f && pipe.transform.position.x > -6.4f))
			alive = 0;
		if(pigeon.transform.position.y < pipe2.transform.position.y - 1.5f && (pipe2.transform.position.x < -3.8f && pipe2.transform.position.x > -6.4f))
			alive = 0;
		if(pigeon.transform.position.y > pipe2.transform.position.y + 1.3f && (pipe2.transform.position.x < -3.8f && pipe2.transform.position.x > -6.4f))
			alive = 0;
		if((pipe.transform.position.x > 8 || pipe2.transform.position.x > 8) && alive == 1)
		{
			pass = 1;
		}
		if((pipe.transform.position.x < -6.5f || pipe2.transform.position.x < -6.5f) && alive == 1 && pass == 1)
		{
			score += 5;
			pass = 0;
		}

		if(alive == 0 && death == 0)
		{
				Debug.Log("score : " + score + "\n" + "Balloon life time: " + Mathf.RoundToInt(Time.realtimeSinceStartup) + "s");
				death = 1;
		}
	}
}
