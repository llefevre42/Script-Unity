using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameLevel : MonoBehaviour {

	public Text text;
	public GameObject data1;
	public GameObject data2;
	public GameObject data3;
	public GameObject data4;
	void Update () {

		if(data1.GetComponent<cam_Pos>().select == 1)
		text.text = "Level 1 - London";
		if(data2.GetComponent<cam_Pos>().select == 1)
		text.text = "Level 2 - Dumbo";
		if(data3.GetComponent<cam_Pos>().select == 1)
		text.text = "Level 3 - Not Flat";
		if(data4.GetComponent<cam_Pos>().select == 1)
		text.text = "Level 4 - The Reponse";
	}
}
