using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wonPannel : MonoBehaviour {
	public GameObject data;

	public GameObject obj;
	private int nevercall = 0;

	public AudioSource audi1;
	public AudioSource audi2;

	void Update () 
	{
		if(data.GetComponent<winConMono>().finish == 1 && nevercall == 0)
		{
			nevercall = 1;
			StartCoroutine(Fade());
		}
	}
	private IEnumerator Fade()
	{
		audi1.Stop();
		if(PlayerPrefs.GetInt("Mute") == 0)
			audi2.Play();
		while (obj.transform.position.y > 141)
		{
			Debug.Log(obj.transform.position.y);
			obj.transform.position = new Vector2(obj.transform.position.x, obj.transform.position.y - 4);
			yield return null;
		}
	}
}
