using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScriptEx02 : MonoBehaviour {

	public float jump;
	public float speed;
	public int playerNumber;
	public GameObject CurrentPlayer;
	public Rigidbody2D Player;

	void Start ()
	{
		 CurrentPlayer = GameObject.FindGameObjectWithTag("CurrentPlayer");
	}
	void FixedUpdate()
	 {
		 if(playerNumber == int.Parse(CurrentPlayer.GetComponent<Text>().text))
 		{
 			if(Input.GetKeyDown("space") && Player.velocity == new Vector2(0,0))
 				Player.velocity = new Vector3(0, jump, 0);
		 if(Input.GetKey(KeyCode.LeftArrow))
		 {
				transform.Translate(new Vector3(-1 ,0 ,0) * speed *  Time.deltaTime);
		 }
		 if(Input.GetKey(KeyCode.RightArrow))
		 {
				transform.Translate(new Vector3(1 ,0 ,0) * speed *  Time.deltaTime);

		 }
	 	}
	 }
}
