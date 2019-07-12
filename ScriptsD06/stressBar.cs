using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stressBar : MonoBehaviour {
	public GameObject red;
	public RectTransform redTra;
	public float stress;
	private float startRedPos;
	public AudioSource audi;
	public AudioSource audi2;
	public AudioSource audi3;
	private int stressed;
	public GameObject Loose;
	public GameObject Pannel;
	private int nevercall;

	// Use this for initialization
	void Start () {
		startRedPos = red.transform.position.x;
	}

	// Update is called once per frame
	void Update ()
	{
		if(stress > 500)
			stress = 500;
		if(stress >= 500 && nevercall == 0)
		{
			nevercall = 1;
			Pannel.SetActive(true);
			Loose.SetActive(true);
			audi2.Play();
			StartCoroutine(Fade());
		}
		if(stress > 375 && stressed == 0)
		{
			audi.Play();
			audi3.Stop();
			stressed = 1;
		}
		else if(stress < 375 && stressed == 1)
		{
			audi.Stop();
			audi3.Play();
			stressed = 0;
		}
		red.transform.position = new Vector3(startRedPos + stress / 2, red.transform.position.y, 0);
		redTra.sizeDelta = new Vector2(stress, 100);
		stress -= 0.5f;
	}

	private IEnumerator Fade()
	{
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
