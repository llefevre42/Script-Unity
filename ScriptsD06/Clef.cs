using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clef : MonoBehaviour {
	public GameObject clef;
	public int clefRecup = 0;
	public AudioSource audi;
	private int nevercall;
	private float alpha;
	public Text Begin;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision)
	 {
			 if(collision.gameObject.name == "Main Camera" && nevercall == 0)
			 {
				nevercall = 1;
				audi.Play();
			 	GameObject.Destroy(clef);
				clefRecup = 1;
				 StartCoroutine(Fade());
			}
	 }

	 private IEnumerator Fade()
	 {
		 while(alpha < 1)
		 {
			 alpha += 0.005f;
			 Begin.color = new Color(1,1,1, alpha);
			 yield return null;
		 }
		 yield return new WaitForSeconds(2);
		 StartCoroutine(FadeOut());
	 }

	 private IEnumerator FadeOut()
	 {
		 while(alpha > 0)
		 {
			 alpha -= 0.005f;
			 Begin.color = new Color(1,1,1, alpha);
			 yield return null;
		 }
	 }
}
