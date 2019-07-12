using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankDepla : MonoBehaviour {
	public GameObject tank;
	public GameObject body;
	public float avance;
	private float tourne;

	void FixedUpdate ()
	{
		if(Input.GetKey(KeyCode.A))
		{
			tourne -= 2;
			body.transform.Rotate(Vector3.up, -40 * Time.deltaTime); //= Quaternion.Euler(0, tourne* Time.deltaTime, 0);
	//		tank.transform.rotation = Quaternion.Euler(0, 1, 0);
		}
		if(Input.GetKey(KeyCode.D))
		{
			tourne += 2;
			body.transform.Rotate(Vector3.up, 40 * Time.deltaTime); //= Quaternion.Euler(0, tourne * Time.deltaTime, 0);
	//		tank.transform.rotation = Quaternion.Euler(0, -1, 0);
		}
		if(Input.GetKey(KeyCode.W))
		{
			tank.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime *  avance);
		}
		if(Input.GetKey(KeyCode.S))
		{
			tank.transform.Translate(new Vector3(0, 0,-1) * Time.deltaTime * avance);
		}

	//	tank.transform.position = new Vector3(tank.transform.position.x, tank.transform.position.y, tank.transform.position.z + avance);
	}
}
