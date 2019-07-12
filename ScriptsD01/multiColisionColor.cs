using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multiColisionColor : MonoBehaviour {

	public GameObject plat;
	private GameObject currentcolor;
	private int swit;
	private float start;

	void Start ()
	{
		currentcolor = GameObject.FindGameObjectWithTag("platformColor");
		swit = int.Parse(currentcolor.GetComponent<Text>().text);
	}
	void Update () {
			swit = int.Parse(currentcolor.GetComponent<Text>().text);
			if(swit == 1)
			{
				plat.GetComponent<Renderer> ().material.color = new Color(1, 0, 0);
				plat.layer= 8;
			}
			else if(swit == 2)
			{
				plat.GetComponent<Renderer> ().material.color = new Color(1, 1, 0);
				plat.layer= 9;
			}
			else if(swit == 3)
			{
				plat.GetComponent<Renderer> ().material.color = new Color(0, 0, 1);
				plat.layer= 10;
			}
	}
}
