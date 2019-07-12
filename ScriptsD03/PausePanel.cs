using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour {
	public GameObject DeathPanel;
	public GameObject DeathPanel2;
	public GameObject data;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			DeathPanel.SetActive(true);
			data.GetComponent<gameManager>().pause(true);
		}
	}
		public void Resume()
		{
			DeathPanel.SetActive(false);
			data.GetComponent<gameManager>().pause(false);
		}

		public void Exit()
		{
			DeathPanel2.SetActive(true);
			DeathPanel.SetActive(false);
		}

		public void SurYes()
		{
			Application.Quit();
		}
		
		public void SurNo()
		{
			DeathPanel2.SetActive(false);
			DeathPanel.SetActive(true);
		}
}
