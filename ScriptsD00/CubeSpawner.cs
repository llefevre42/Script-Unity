using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject ObjA;
	private GameObject MyObjA;
	public GameObject ObjB;
	private GameObject MyObjB;
	public GameObject ObjC;
	private GameObject MyObjC;
	private float delay;
	public KeyCode keyA;
	public KeyCode keyB;
	public KeyCode keyC;

	private int rotate = 1;

	void Start ()
	{
		delay = Random.Range(0.1f, 5.0f);
	}
	// Update is called once per frame
	void Update ()
	{
		if(delay == 0)
		{
			if(rotate == 1)
			{
				MyObjA = (GameObject)GameObject.Instantiate(ObjA, ObjA.transform.position, Quaternion.identity);
				rotate = 2;
			}
			else if(rotate == 2)
			{
				MyObjB = (GameObject)GameObject.Instantiate(ObjB, ObjB.transform.position, Quaternion.identity);
				rotate = 3;
			}
			else if(rotate == 3)
			{
				MyObjC = (GameObject)GameObject.Instantiate(ObjC, ObjC.transform.position, Quaternion.identity);
				rotate = 1;
			}
				delay = Random.Range(0.1f, 5.0f);
		}
		else
		{
			delay -= 0.1f;
			if(delay < 0)
				delay = 0;
		}
		if(Input.GetKeyDown(keyA) && MyObjA)
		{
			if(MyObjA.transform.position.y > -8.7f)
				Debug.Log("precision " + (MyObjA.transform.position.y / -8.7f * 100));
			GameObject.Destroy(MyObjA);
		}
		if(Input.GetKeyDown(keyB) && MyObjB)
		{
			if(MyObjB.transform.position.y > -8.7f)
				Debug.Log("precision " + (MyObjB.transform.position.y / -8.7f * 100));
			GameObject.Destroy(MyObjB);
		}
		if(Input.GetKeyDown(keyC) && MyObjC)
		{
			if(MyObjC.transform.position.y > -8.7f)
				Debug.Log("precision " + (MyObjC.transform.position.y / -8.7f * 100));
			GameObject.Destroy(MyObjC);
		}

	}
}
