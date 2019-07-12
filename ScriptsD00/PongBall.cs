using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

	public GameObject ball;
	public GameObject toit;
	public GameObject sol;
	public GameObject p1;
	public GameObject p2;
	public int direction;
	private int scoreP1 = 0;
	private int scoreP2 = 0;

	void Start ()
	{
	}

	void Update ()
	{
		if(direction == 1)
			transform.Translate(new Vector3(-0.2f, -0.2f, 0));
		if(direction == 2)
			transform.Translate(new Vector3(0.2f, 0.2f, 0));
		if(direction == 3)
			transform.Translate(new Vector3(0.2f, -0.2f, 0));
		if(direction == 4)
			transform.Translate(new Vector3(-0.2f, 0.2f, 0));
		if(ball.transform.position.y + 0.5f > toit.transform.position.y - 0.5f)
		{
			if(direction == 2)
				direction = 3;
			if(direction == 4)
				direction = 1;
		}
		if(ball.transform.position.y - 0.5f < sol.transform.position.y + 0.5f)
		{
			if(direction == 3)
				direction = 2;
			if(direction == 1)
				direction = 4;
		}
		if(ball.transform.position.x - 0.5f < p1.transform.position.x + 0.5f && ball.transform.position.y < p1.transform.position.y + 1.5 && ball.transform.position.y > p1.transform.position.y - 1.5 )
		{
			if(direction == 1)
				direction = 3;
			if(direction == 4)
				direction = 2;
		}
		if(ball.transform.position.x + 0.5f > p2.transform.position.x - 0.5f && ball.transform.position.y < p2.transform.position.y + 1.5 && ball.transform.position.y > p2.transform.position.y - 1.5 )
		{
			if(direction == 3)
				direction = 1;
			if(direction == 2)
				direction = 4;
		}
		if(ball.transform.position.x + 0.5f < -8.5f)
		{
			scoreP2++;
			Debug.Log("Player 1: " + scoreP1 +" | " + "Player 2: " + scoreP2 );
			ball.transform.position = new Vector3(0,0,0);
		}
		if(ball.transform.position.x - 0.5f > 8.5f)
		{
			scoreP1++;
			Debug.Log("Player 1: " + scoreP1 +" | " + "Player 2: " + scoreP2 );
				ball.transform.position = new Vector3(0,0,0);
		}
	}
}
