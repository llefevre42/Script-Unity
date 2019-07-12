using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_obj_duo_earth : MonoBehaviour {
	private float rotationX = 0;
	private  float rotationY = 0;
	public  GameObject data;
	public  GameObject data2;
	public GameObject obj_deselect;
	public GameObject obj;
	public int select = 0;
		public AudioSource audi1;
	void Start()
	{
		if(PlayerPrefs.GetInt("Mute") == 1)
			audi1.Stop();
	}
	public void OnMouseDown()
	{	
		obj_deselect.GetComponent<Rotate_obj_duo_earth>().select = 0;
		select = 1;
	}
 	void Update()
	{
		if(data.GetComponent<WinConDuoEarth>().finish == 0 && select == 1 && data2.GetComponent<PausePannel>().visible == 0)
		{
			if(Input.GetMouseButton(0)|| Input.GetKey("q"))
			{
				rotationX += Input.GetAxis("Mouse X") * 8;
			}
			if(Input.GetMouseButton(1)|| Input.GetKey("w"))
			{
				rotationY += Input.GetAxis("Mouse Y") * 8;
			}
			obj.transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
			if(Input.GetKey("space"))
			{
				obj.transform.position = new Vector3(obj.transform.position.x + Input.GetAxis("Mouse X"), obj.transform.position.y +  Input.GetAxis("Mouse Y")  , obj.transform.position.z + Input.GetAxis("Mouse X"));
				if(obj.transform.position.x < -155)
					obj.transform.position = new Vector3(-155, obj.transform.position.y , 0);
				if(obj.transform.position.x > -100)
					obj.transform.position = new Vector3(-100, obj.transform.position.y , 60);
				if(obj.transform.position.y > 410)
					obj.transform.position = new Vector3(obj.transform.position.x, 410, obj.transform.position.z);
				if(obj.transform.position.y < 350)
					obj.transform.position = new Vector3(obj.transform.position.x, 350, obj.transform.position.z);
			}
		}
	}
}