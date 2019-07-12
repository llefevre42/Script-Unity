using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChangePlat : MonoBehaviour
{
	public GameObject but1;
	public GameObject but2;
	public GameObject but3;
	public GameObject but4;
	public GameObject P1;
	public GameObject P2;
	public GameObject P3;
	private Color colo;
	public GameObject plateformcolor;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

	}
	void OnCollisionEnter2D(Collision2D col)
	{
			if(col.gameObject.name == P1.name)
			{
				colo = new Color(1, 0, 0);
			plateformcolor.GetComponent<Text>().text = 1 + "";
			}
			if(col.gameObject.name == P2.name)
			{
				colo = new Color(1, 1, 0);
				plateformcolor.GetComponent<Text>().text = 2 + "";
			}
			if(col.gameObject.name == P3.name)
			{
				colo = new Color(0, 0, 1);
				plateformcolor.GetComponent<Text>().text = 3 + "";
			}
			but1.GetComponent<Renderer> ().material.color = colo;
			but2.GetComponent<Renderer> ().material.color = colo;
			but3.GetComponent<Renderer> ().material.color = colo;
			but4.GetComponent<Renderer> ().material.color = colo;
	}
}
