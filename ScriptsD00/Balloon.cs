using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

	public GameObject obj;
	public float scale;
	public KeyCode key;
	private float keepCalm;
	private int respire;

	void Update ()
	{
			if(Input.GetKeyDown(key) && obj.transform.localScale.x > 0 && obj.transform.localScale.y > 0 && respire == 1)
			{
				  obj.transform.localScale += new Vector3(scale * 25, scale * 25, 0);
					keepCalm += 10;
			}
			else
			{
				if(obj.transform.localScale.x >= 0 && obj.transform.localScale.y >= 0)
				{
					obj.transform.localScale -= new Vector3(scale * 2, scale * 2, 0);
					if(obj.transform.localScale.x < 0 || obj.transform.localScale.y < 0)
					{
						obj.transform.localScale = new Vector3(0, 0, 0);
					}
				}
			}
				if(keepCalm > 50)
					respire = 0;
				if(keepCalm <= 0)
				{
					respire = 1;
				}
				if(keepCalm > 0)
					keepCalm -= 0.7f;
			if((obj.transform.localScale.x == 0 && obj.transform.localScale.y == 0) || (obj.transform.localScale.x > 20 && obj.transform.localScale.y > 20) )
			{
				GameObject.Destroy(obj);
				Debug.Log ("Balloon life time: " + Mathf.RoundToInt(Time.realtimeSinceStartup) + "s");
			}
		}
}
