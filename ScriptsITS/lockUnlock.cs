using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockUnlock : MonoBehaviour {
	public int sucess = 0;
	public int pending = 0;
 	public Texture locked, unlocked;
	Renderer m_Renderer;
	public string sucess1;
	public string pending1;
	// Use this for initialization
	void Start () {
		pending = PlayerPrefs.GetInt(pending1);
		sucess = PlayerPrefs.GetInt(sucess1);
		m_Renderer = GetComponent<Renderer> ();
		m_Renderer.material.SetTexture("_MainTex", locked);
		m_Renderer.material.mainTextureScale = new Vector2(0.5f, -1);
		if(pending == 1)
		{
			m_Renderer = GetComponent<Renderer> ();
			m_Renderer.material.color = Color.blue;
		}
		if(sucess == 1)
		{
			m_Renderer.material.color = Color.white;
			m_Renderer = GetComponent<Renderer> ();
			m_Renderer.material.SetTexture("_MainTex", unlocked);
			m_Renderer.material.mainTextureScale = new Vector2(0.5f, -1);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
