using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
	public List<deplacement> heroes = new List<deplacement>();
	public deplacement heroSource;
	public GameObject orc;
	public GameObject castle;
	public GameObject orcCastle;
	private float nextActionTime = 10.0f;
	public float period = 10.0f;
	private int go = 0;

	void Update ()
	{
		if (Time.time > nextActionTime )
		{
				deplacement heroBis = (deplacement)Instantiate(heroSource, new Vector3(castle.transform.position.x + 2, castle.transform.position.y - 1, 0), Quaternion.identity);
				GameObject orcBis = (GameObject)Instantiate(orc, new Vector3(orcCastle.transform.position.x - 2, orcCastle.transform.position.y - 1, 0), Quaternion.identity);
				heroes.Add(heroBis);
				nextActionTime += period;
		 }
		foreach(deplacement hero in heroes)
		{
				if(hero.click == 1)
				{
					if(!(Input.GetKey(KeyCode.LeftControl)))
					{
						Clean();
					}
					hero.actif = 1;
				}
				else if(Input.GetMouseButtonDown(0) && hero.actif == 1 && hero.click == 0)
				{
					if(!(Input.GetKey(KeyCode.LeftControl)))
					{
						hero.IsClicked();
						go = 1;
					}
				}
				else if (Input.GetMouseButtonDown(1))
					Clean();
				hero.click = 0;
		}
		foreach(deplacement hero in heroes)
		{
			if(hero.actif == 1 && go == 1)
			{
				hero.Charger();
			}
		}
	}
	void Clean()
	{
		foreach(deplacement hero in heroes)
		{
				hero.actif = 0;
				hero.clicked.origin = hero.transform.position;
		}
	}
}
