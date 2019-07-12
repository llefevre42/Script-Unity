using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retryPannel : MonoBehaviour {
	public string lv;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void SurYes()
	{
		Application.LoadLevel(lv);
	}

	public void Exit()
	{
		Application.Quit();
	}
}
