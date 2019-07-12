using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam01 : MonoBehaviour {
	public List<deplacement> heroes = new List<deplacement>();
	private int go = 0;

	void Update ()
	{
		foreach(deplacement hero in heroes)
		{
				if(hero.click == 1)
				{
					if(!(Input.GetKey(KeyCode.LeftControl)))
						Clean();
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
