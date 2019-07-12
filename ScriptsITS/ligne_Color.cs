using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ligne_Color : MonoBehaviour {
	public GameObject data1,data2;
	Renderer m_Renderer;
	// Use this for initialization
	void Start () {
		m_Renderer = GetComponent<Renderer> ();
		m_Renderer.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(data2.GetComponent<lockUnlock>().pending == 1)
		{
			m_Renderer.material.color = Color.blue;
		}
		if(data2.GetComponent<lockUnlock>().sucess == 1)
		{
			m_Renderer.material.color = Color.green;
		}
	}
}