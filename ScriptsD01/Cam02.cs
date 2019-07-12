using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cam02 : MonoBehaviour
{
	public KeyCode KeyPlayerOne;
	public KeyCode KeyPlayerTwo;
	public KeyCode KeyPlayerThree;
	public GameObject Camera;
	public GameObject CurrentPlayer;
	public GameObject PlayerOne;
	public GameObject PlayerTwo;
	public GameObject PlayerThree;
	public GameObject HitBoxOne;
	public GameObject HitBoxTwo;
	public GameObject HitBoxThree;
	public Rigidbody2D rb1;
	public Rigidbody2D rb2;
	public Rigidbody2D rb3;
	public string level;
	private int gg = 0;
	private int playerNumber;

	// Use this for initialization
	void Start () {
		CurrentPlayer = GameObject.FindGameObjectWithTag("CurrentPlayer");
		playerNumber = int.Parse(CurrentPlayer.GetComponent<Text>().text);
		rb1.constraints = RigidbodyConstraints2D.FreezeRotation;
		rb2.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		rb3.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyPlayerOne))
		{
			playerNumber = 1;
			CurrentPlayer.GetComponent<Text>().text = 1 + "";
			rb1.constraints = RigidbodyConstraints2D.FreezeRotation;
			rb2.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
			rb3.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		}
		if(Input.GetKeyDown(KeyPlayerTwo))
		{
			playerNumber = 2;
			CurrentPlayer.GetComponent<Text>().text = 2 + "";
			rb2.constraints = RigidbodyConstraints2D.FreezeRotation;
			rb1.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
			rb3.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		}
		if(Input.GetKeyDown(KeyPlayerThree))
		{
			playerNumber = 3;
			CurrentPlayer.GetComponent<Text>().text = 3 + "";
			rb3.constraints = RigidbodyConstraints2D.FreezeRotation;
			rb2.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
			rb1.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		}
		if(playerNumber == 1)
			Camera.transform.position = new Vector3(PlayerOne.transform.position.x, PlayerOne.transform.position.y, Camera.transform.position.z);
		if(playerNumber == 2)
			Camera.transform.position = new Vector3(PlayerTwo.transform.position.x, PlayerTwo.transform.position.y, Camera.transform.position.z);
		if(playerNumber == 3)
			Camera.transform.position = new Vector3(PlayerThree.transform.position.x, PlayerThree.transform.position.y, Camera.transform.position.z);
		if(1 == int.Parse(HitBoxOne.GetComponent<Text>().text) && 1 == int.Parse(HitBoxTwo.GetComponent<Text>().text) && 1 == int.Parse(HitBoxThree.GetComponent<Text>().text) && gg == 0)
		{
			Application.LoadLevel(level);
		}
		if(Input.GetKeyDown("r"))
		{
			Application.LoadLevel("ex03");
		}
	}
	}
