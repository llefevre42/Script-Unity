using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConDuo : MonoBehaviour {


 public GameObject form1;
 public GameObject form2;
 public float x1;
 public float y1;
 public float x2;
 public float y2;
	
public int finish = 0; 
 public string Progress1;
 public string Pending1;

 public string Pending2;
 public string Pending3;

 public float preci1;

 public float preci2;
 public float preci3;
 public float preci4;

	void Update () {
		Debug.Log("form1 = " + form1.transform.rotation.eulerAngles.x + " " + form1.transform.rotation.eulerAngles.y);
		Debug.Log("form2 = " + form2.transform.rotation.eulerAngles.x + " " + form2.transform.rotation.eulerAngles.y);
		if(form1.transform.rotation.eulerAngles.x > x1 - 10 && form1.transform.rotation.eulerAngles.x < x1 + 10 && form1.transform.rotation.eulerAngles.y > y1 - 10 && form1.transform.rotation.eulerAngles.y < y1 + 10)
		{
			Debug.Log("in1");
			if(form2.transform.rotation.eulerAngles.x > x2 - 10 && form2.transform.rotation.eulerAngles.x < x2 + 10 && form2.transform.rotation.eulerAngles.y > y2 - 10 && form2.transform.rotation.eulerAngles.y < y2 + 10)
			{
				Debug.Log("in2");
				if(((form1.transform.position.x - form2.transform.position.x) > preci1 && (form1.transform.position.x - form2.transform.position.x) < preci2) 
				&& ((form1.transform.position.y - form2.transform.position.y) > preci3 && (form1.transform.position.y - form2.transform.position.y) < preci4))
				{
					Debug.Log("in3");
					finish = 1;
					PlayerPrefs.SetInt(Progress1, 1);
					PlayerPrefs.SetInt(Pending1, 0);
					PlayerPrefs.SetInt(Pending2, 1);
					PlayerPrefs.SetInt(Pending3, 1);
				}		
			}
		}
		
	}
}
