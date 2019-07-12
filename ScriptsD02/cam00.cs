using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam00 : MonoBehaviour {
	public List<deplacement> heroes = new List<deplacement>();
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			foreach(deplacement hero in heroes)
			{
				Debug.Log("deplacement");
				hero.IsClicked();
			}
		}
		foreach(deplacement hero in heroes)
		{
			hero.Charger();
		}
	}
}
