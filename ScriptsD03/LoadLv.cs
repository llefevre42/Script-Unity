using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLv : MonoBehaviour {
	public string lv;
	public void LoadLevel()
	{
		Application.LoadLevel(lv);
	}
}
