using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statTourelle : MonoBehaviour {
	public GameObject CoolDown;
	public GameObject Power;
	public GameObject SpeedFire;
	public GameObject Energie;
	public GameObject Tower;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		CoolDown.GetComponent<Text>().text = Tower.GetComponent<towerScript>().range.ToString();
		Power.GetComponent<Text>().text = Tower.GetComponent<towerScript>().damage.ToString();
		SpeedFire.GetComponent<Text>().text = Tower.GetComponent<towerScript>().fireRate.ToString();
		Energie.GetComponent<Text>().text = Tower.GetComponent<towerScript>().energy.ToString();
	}
}
