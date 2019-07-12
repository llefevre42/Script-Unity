using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class porte : MonoBehaviour {
	public GameObject porti;
	public int color;
	private GameObject currentcolor;
	private int swit;
	private float start;
	void Start () {
		if(color == 1)
			currentcolor = GameObject.FindGameObjectWithTag("marqueurRed");
		if(color == 2)
			currentcolor = GameObject.FindGameObjectWithTag("marqueurYellow");
		if(color == 3)
			currentcolor = GameObject.FindGameObjectWithTag("marqueurBlue");
		swit = int.Parse(currentcolor.GetComponent<Text>().text);
		start = porti.transform.position.y;
	}

	// Update is called once per frame
	void Update () {
				swit = int.Parse(currentcolor.GetComponent<Text>().text);
			if(swit == 1 && start + 0.5 > porti.transform.position.y)
					porti.transform.position = new Vector2(porti.transform.position.x, porti.transform.position.y + 2f);
			if(swit == 0 && start < porti.transform.position.y)
					porti.transform.position = new Vector2(porti.transform.position.x, start);
	}
}
