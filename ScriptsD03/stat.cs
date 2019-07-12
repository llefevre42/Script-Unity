using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat : MonoBehaviour {
	public GameObject data;
	public GameObject finish;
	public GameObject WinPannel;
	public int win = 1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	//	Debug.Log(data.GetComponent<gameManager>().score);
//		Debug.Log(data.GetComponent<gameManager>().currentWave);
	//	Debug.Log(data.GetComponent<gameManager>().lastWave);
	//	Debug.Log(data.GetComponent<gameManager>().score);
		//finish.GetComponent<ennemyScript>().checkLastEnemy();
		if (data.GetComponent<gameManager>().lastWave == true) {
			GameObject[] spawners = GameObject.FindGameObjectsWithTag("spawner");
			foreach (GameObject spawner in spawners) {
				if (spawner.GetComponent<ennemySpawner>().isEmpty == false || spawner.transform.childCount > 1) {
					return ;
				}
			}
			if(win == 1)
			{
				WinPannel.SetActive(true);
				win = 0;
			}
		}
	}
}
