using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeValue : MonoBehaviour {
	public GameObject Hp;
	public GameObject Tower;
	public GameObject RetryPannel;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Hp.GetComponent<Text>().text = Tower.GetComponent<gameManager>().playerHp.ToString();
		if(Tower.GetComponent<gameManager>().playerHp <= 0)
			RetryPannel.SetActive(true);
	}
}
