using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeBouton : MonoBehaviour {
	public Text Title;
	public Text Play;
	public Text Cheat;
	private float alphaOne = 0;
	private float alphaTwo = 0;
	private float alphaThree = 0;
	void Start () {
		StartCoroutine(FadeName());
	
		
	}
	 private IEnumerator FadeName()
	 {
		 while(alphaOne < 1)
		 {
			 alphaOne += 0.003f;
			 Title.color = new Color(0,0,0, alphaOne);
			 yield return null;
		 }
		 yield return new WaitForSeconds(1);
		StartCoroutine(FadePlay());
	 }

	 private IEnumerator FadePlay()
	 {
		 while(alphaTwo < 1)
		 {
			 alphaTwo += 0.003f;
			 Play.color = new Color(0,0,0, alphaTwo);
			 yield return null;
		 }
		 yield return new WaitForSeconds(1);
		 StartCoroutine(FadeCheat());
	 }

	 private IEnumerator FadeCheat()
	 {
		 while(alphaThree < 1)
		 {
			 alphaThree += 0.002f;
			 Cheat.color = new Color(0.5f,0.5f,0.5f, alphaThree);
			 yield return null;
		 }
		 yield return new WaitForSeconds(2);
	 }
}
