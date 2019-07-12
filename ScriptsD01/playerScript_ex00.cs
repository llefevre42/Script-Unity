using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript_ex00 : MonoBehaviour {

	public float jump;
	public int playerNumber;
	public GameObject CurrentPlayer;
	public Rigidbody2D Player;

	// Use this for initialization
	void Start () {
		 CurrentPlayer = GameObject.FindGameObjectWithTag("CurrentPlayer");
	}

	// Update is called once per frame
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
				transform.Translate(new Vector3(-2f, 0, 0) *  Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Translate(new Vector3(2f, 0, 0) *  Time.deltaTime);
			}
		}
	}
}
