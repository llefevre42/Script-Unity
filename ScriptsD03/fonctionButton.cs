using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonctionButton : MonoBehaviour {
	public GameObject data;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void PauseButton ()
	{
		data.GetComponent<gameManager>().pause(true);
	}
	public void Speed1 ()
	{
		data.GetComponent<gameManager>().changeSpeed(1);
	}
	public void Speed4 ()
	{
		data.GetComponent<gameManager>().changeSpeed(4);
	}
	public void Speed8 ()
	{
		data.GetComponent<gameManager>().changeSpeed(8);
	}
}
