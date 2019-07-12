using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void	start()
	{
		Application.LoadLevel("ex01");
	}

	public void	Exit()
	{
	 	Application.Quit();
	}
}
