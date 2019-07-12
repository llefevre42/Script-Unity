using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_Level_Menu : MonoBehaviour {
	public GameObject data;
	private float rotationX = 0;
	private  float rotationY = 0;
	public float max;
 	void Update()
	{
		if(data.GetComponent<cam_Pos>().select == 1)
		{
			rotationX -= Input.GetAxis("Mouse X") * 8;
			rotationY += Input.GetAxis("Mouse Y") * 8;
			if(rotationX > max)
				rotationX = max;
			if(rotationY > max) 
				rotationY = max;
			if(rotationY < -max)
				rotationY = -max;
			if(rotationX < -max)
				rotationX = -max;
			transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
		}
	}
}
