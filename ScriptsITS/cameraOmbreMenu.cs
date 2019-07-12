using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraOmbreMenu : MonoBehaviour {
	public GameObject cam;
	public GameObject obj;
	public int pos;
	void Update () 
	{
		if(pos == 1)
			obj.transform.position = new Vector3(cam.transform.position.x - 5, cam.transform.position.y + 5, -40);
		if(pos == 2)
			obj.transform.position = new Vector3(cam.transform.position.x - 5, cam.transform.position.y - 5, -40);
		if(pos == 3)
			obj.transform.position = new Vector3(cam.transform.position.x + 5, cam.transform.position.y - 5, -40);
		if(pos == 4)
			obj.transform.position = new Vector3(cam.transform.position.x + 5, cam.transform.position.y + 5, -40);
	}
}
