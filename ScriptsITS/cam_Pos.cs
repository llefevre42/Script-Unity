using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cam_Pos : MonoBehaviour {
	public GameObject cam, obj;
	public GameObject obj1, obj2, obj3;
	public int select = 0;

	public string scenename;

	public void OnMouseDown()
	{	
		ClearAll();
		if(obj.GetComponent<cam_Pos>().select == 1 && (obj.GetComponent<lockUnlock>().pending == 1 || obj.GetComponent<lockUnlock>().sucess == 1))
		{
			  SceneManager.LoadScene(scenename);
		}
		else
			select = 1;
		cam.transform.position = new Vector3 (obj.transform.position.x,obj.transform.position.y, cam.transform.position.z );
	}
	public void ClearAll()
	{
		obj1.GetComponent<cam_Pos>().select = 0;
		obj2.GetComponent<cam_Pos>().select = 0;
		obj3.GetComponent<cam_Pos>().select = 0;
	}
}
