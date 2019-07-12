using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePannel : MonoBehaviour {
	public GameObject PausePanel;
	public int visible = 0;
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape) && visible == 0)
		{
			visible = 1;
			PausePanel.SetActive(true);
		}
		else if(Input.GetKeyDown(KeyCode.Escape) && visible == 1)
		{
			visible = 0;
			PausePanel.SetActive(false);
		}
	}
}
