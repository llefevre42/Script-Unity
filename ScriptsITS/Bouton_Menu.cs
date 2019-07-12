using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bouton_Menu : MonoBehaviour {
	public void Start()
	{
		PlayerPrefs.SetInt("Pending1", 1);
	}

	public void Play()
	{
		SceneManager.LoadScene("menu_level");
	}
	public void Cheat()
	{
		PlayerPrefs.SetInt("Pending1", 0);
		PlayerPrefs.SetInt("Pending2", 0);
		PlayerPrefs.SetInt("Pending31", 0);
		PlayerPrefs.SetInt("Pending32", 0);
		PlayerPrefs.SetInt("Progress1", 1);
		PlayerPrefs.SetInt("Progress2", 1);
		PlayerPrefs.SetInt("Progress31", 1);
		PlayerPrefs.SetInt("Progress32", 1);
		SceneManager.LoadScene("menu_level");
	}
	public void Reset()
	{
		PlayerPrefs.SetInt("Pending1", 1);
		PlayerPrefs.SetInt("Pending2", 0);
		PlayerPrefs.SetInt("Pending31", 0);
		PlayerPrefs.SetInt("Pending32", 0);
		PlayerPrefs.SetInt("Progress1", 0);
		PlayerPrefs.SetInt("Progress2", 0);
		PlayerPrefs.SetInt("Progress31", 0);
		PlayerPrefs.SetInt("Progress32", 0);
	}
}
