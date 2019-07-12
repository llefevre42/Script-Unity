using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinColl : MonoBehaviour {

	public GameObject win;
	public GameObject Pannel;
	public AudioSource audi;
	private int nevercall;
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
	//			 Time.timeScale = 0;
					nevercall = 1;
					audi.Play();
				 Pannel.SetActive(true);
				 win.SetActive(true);
				 StartCoroutine(Fade());
			}
	 }

	 private IEnumerator Fade()
	 {
		 yield return new WaitForSeconds(5);
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	 }
}
