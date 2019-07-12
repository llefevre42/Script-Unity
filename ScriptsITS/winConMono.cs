using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winConMono : MonoBehaviour {

 public GameObject form;
 public float x;
 public float y;
	
public int finish = 0; 
 public string Progress1;
 public string Pending1;

 public string Pending2;
 public string Pending3;


	void Update () {
	//	Debug.Log(form.transform.rotation.eulerAngles.x + " " +  form.transform.rotation.eulerAngles.y);
		if(form.transform.rotation.eulerAngles.x > x - 5 && form.transform.rotation.eulerAngles.x < x + 5)
		{
			if(form.transform.rotation.eulerAngles.y > y - 5 && form.transform.rotation.eulerAngles.y < y + 5)
			{	
				finish = 1;
				PlayerPrefs.SetInt(Progress1, 1);
				PlayerPrefs.SetInt(Pending1, 0);
				PlayerPrefs.SetInt(Pending2, 1);
				PlayerPrefs.SetInt(Pending3, 1);
			//	StartCoroutine(Fade());
				
			}
		}
		
	}
	 private IEnumerator Fade()
	 {
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene("menu_level");
	 }
}
