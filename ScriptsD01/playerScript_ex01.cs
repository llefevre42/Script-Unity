using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript_ex01 : MonoBehaviour {

	public float jump;
	public float speed;
	public int playerNumber;
	public GameObject CurrentPlayer;
	public Rigidbody2D Player;


	// Use this for initialization
	void Start ()
	{
		 CurrentPlayer = GameObject.FindGameObjectWithTag("CurrentPlayer");
	}

	void FixedUpdate()
	 {
		 if(playerNumber == int.Parse(CurrentPlayer.GetComponent<Text>().text))
 		{
 			if(Input.GetKeyDown("space") && Player.velocity == new Vector2(0,0))
 			{
 				Player.velocity = new Vector3(0, jump, 0);
 			}

		 if(Input.GetKey(KeyCode.LeftArrow))
		 {
			// Player.AddForce(new Vector2(-speed,0));
				transform.Translate(new Vector3(-1 ,0 ,0) * speed *  Time.deltaTime);
		 //	Player.velocity = new Vector3(-speed, Player.velocity.y, 0);
		 }
		 if(Input.GetKey(KeyCode.RightArrow))
		 {

				transform.Translate(new Vector3(1 ,0 ,0) * speed *  Time.deltaTime);
			 //transform.Translate(new Vector3(speed, 0, 0));
		//	 Player.AddForce(new Vector2(speed,0));
		 }
	 	}
	 }
}
