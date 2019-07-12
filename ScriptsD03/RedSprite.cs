using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedSprite : MonoBehaviour {
		public GameObject Energie;
		public GameObject Canon;
		public GameObject Mitra;
		public GameObject Missile;
		public GameObject TowerCanon;
		public GameObject TowerMitra;
		public GameObject TowerMissile;
		public GameObject data;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//	Energie.GetComponent<Text>().text = TowerCanon.GetComponent<towerScript>().energy.ToString();
			Energie.GetComponent<Text>().text = data.GetComponent<gameManager>().playerEnergy.ToString();

			if(int.Parse(Energie.GetComponent<Text>().text) < TowerCanon.GetComponent<towerScript>().energy)
				Canon.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
			else
				Canon.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
			if(int.Parse(Energie.GetComponent<Text>().text) < TowerMitra.GetComponent<towerScript>().energy)
				Mitra.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
			else
				Mitra.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
			if(int.Parse(Energie.GetComponent<Text>().text) < TowerMissile.GetComponent<towerScript>().energy)
				Missile.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
			else
				Missile.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
	}
}
