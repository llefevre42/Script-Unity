using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusCamera : MonoBehaviour {

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
	private int gg = 0;
	private int playerNumber;
	// Use this for initialization
	void Start () {
		CurrentPlayer = GameObject.FindGameObjectWithTag("CurrentPlayer");
		playerNumber = int.Parse(CurrentPlayer.GetComponent<Text>().text);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyPlayerOne))
		{
			playerNumber = 1;
			CurrentPlayer.GetComponent<Text>().text = 1 + "";
		}
		if(Input.GetKeyDown(KeyPlayerTwo))
		{
			playerNumber = 2;
			CurrentPlayer.GetComponent<Text>().text = 2 + "";
		}
		if(Input.GetKeyDown(KeyPlayerThree))
		{
			playerNumber = 3;
			CurrentPlayer.GetComponent<Text>().text = 3 + "";
		}
		if(playerNumber == 1)
			Camera.transform.position = new Vector3(PlayerOne.transform.position.x, PlayerOne.transform.position.y, Camera.transform.position.z);
		if(playerNumber == 2)
			Camera.transform.position = new Vector3(PlayerTwo.transform.position.x, PlayerTwo.transform.position.y, Camera.transform.position.z);
		if(playerNumber == 3)
			Camera.transform.position = new Vector3(PlayerThree.transform.position.x, PlayerThree.transform.position.y, Camera.transform.position.z);
		if(1 == int.Parse(HitBoxOne.GetComponent<Text>().text) && 1 == int.Parse(HitBoxTwo.GetComponent<Text>().text) && 1 == int.Parse(HitBoxThree.GetComponent<Text>().text) && gg == 0)
		{
			Debug.Log("GG");
			gg = 1;
		}
		if(Input.GetKeyDown("r"))
		{
			Application.LoadLevel("ex01");
		}
	}
}
