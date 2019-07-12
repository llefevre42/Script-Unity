using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_obj : MonoBehaviour {
	private float rotationX = 0;
	private  float rotationY = 0;
	public  GameObject data;
	public  GameObject data2;
	public AudioSource audi1;
	void Start()
	{
		if(PlayerPrefs.GetInt("Mute") == 1)
			audi1.Stop();
	}
 	void Update()
	{
		if(data.GetComponent<winConMono>().finish == 0 && data2.GetComponent<PausePannel>().visible == 0)
		{
			if (Input.GetMouseButton(0) || Input.GetKey("q"))
			{
				rotationX += Input.GetAxis("Mouse X") * 8;
			}
			if (Input.GetMouseButton(1) || Input.GetKey("w"))
			{
				rotationY += Input.GetAxis("Mouse Y") * 8;
			}
			transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
		}
	}
}
