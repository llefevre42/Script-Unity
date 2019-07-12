using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour 
{
	public AudioSource audi1;
	void Start()
	{
		if(PlayerPrefs.GetInt("Mute") == 1)
			audi1.Stop();
	}
}
