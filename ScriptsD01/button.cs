using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour {
	public GameObject but1;
	public GameObject but2;
	public GameObject but3;
	public GameObject but4;
	public GameObject P1;
	public GameObject P2;
	public GameObject P3;
	private Color colo;
	public GameObject marqueurRed;
	public GameObject marqueurYellow;
	public GameObject marqueurBlue;
	private int active = 1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

	}
	void OnCollisionEnter2D(Collision2D col)
	{

		if(active == 0)
		{
			colo = new Color(1, 1, 1);
			if(col.gameObject.name == P1.name)
			{
				marqueurRed.GetComponent<Text>().text = 0 + "";
			}
			if(col.gameObject.name == P2.name)
			{
				marqueurYellow.GetComponent<Text>().text = 0 + "";
			}
			if(col.gameObject.name == P3.name)
			{
				marqueurBlue.GetComponent<Text>().text = 0 + "";
			}
			but1.GetComponent<Renderer> ().material.color = colo;
			but2.GetComponent<Renderer> ().material.color = colo;
			but3.GetComponent<Renderer> ().material.color = colo;
			but4.GetComponent<Renderer> ().material.color = colo;
			active = 1;
		}
		else
		{
			if(col.gameObject.name == P1.name)
			{
				colo = new Color(1, 0, 0);
				marqueurRed.GetComponent<Text>().text = 1 + "";
			}
			if(col.gameObject.name == P2.name)
			{
				colo = new Color(1, 1, 0);
				marqueurYellow.GetComponent<Text>().text = 1 + "";
			}
			if(col.gameObject.name == P3.name)
			{
				colo = new Color(0, 0, 1);
				marqueurBlue.GetComponent<Text>().text = 1 + "";
			}
			but1.GetComponent<Renderer> ().material.color = colo;
			but2.GetComponent<Renderer> ().material.color = colo;
			but3.GetComponent<Renderer> ().material.color = colo;
			but4.GetComponent<Renderer> ().material.color = colo;
			active = 0;
		}
	}
}
