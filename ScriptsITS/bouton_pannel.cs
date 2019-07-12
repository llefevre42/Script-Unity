using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_pannel : MonoBehaviour {

	public AudioSource audi;
	public void Retry()
	{
		SceneManager.LoadScene("menu_level");
	}
	public void Exit()
	{
 		Application.Quit();
	}
	public void Mute()
	{
		if(PlayerPrefs.GetInt("Mute") == 1)
		{
			PlayerPrefs.SetInt("Mute", 0);
			audi.Play();
		}
		else if(PlayerPrefs.GetInt("Mute") == 0)
		{
			PlayerPrefs.SetInt("Mute", 1);
			audi.Stop();
		}
	}
}
