using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetState : MonoBehaviour {
		public GameObject Score;
		public GameObject Rank;
		public GameObject data;
		private float Sco;
		private float hpRestant;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		Sco = data.GetComponent<gameManager>().score;
		hpRestant = data.GetComponent<gameManager>().playerHp;
		Score.GetComponent<Text>().text = Sco.ToString();
		if((Sco / (21 - hpRestant)) < 500)
			Rank.GetComponent<Text>().text = "F";
		else if((Sco / (21 - hpRestant)) < 600)
			Rank.GetComponent<Text>().text = "E";
		else if((Sco / (21 - hpRestant)) < 1500)
			Rank.GetComponent<Text>().text = "D";
		else if((Sco / (21 - hpRestant)) < 3000)
			Rank.GetComponent<Text>().text = "C";
		else if((Sco / (21 - hpRestant)) < 4500)
			Rank.GetComponent<Text>().text = "B";
		else if((Sco / (21 - hpRestant)) < 6000)
			Rank.GetComponent<Text>().text = "A";
		else if((Sco / (21 - hpRestant)) < 150000)
			Rank.GetComponent<Text>().text = "S";

	}
}
