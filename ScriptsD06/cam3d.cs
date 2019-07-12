﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cam3d : MonoBehaviour {
	public float mainSpeed = 100.0f;
    public float shiftAdd = 250.0f;
    public float maxShift = 1000.0f;
    public float camSens = 0.25f;
    private Vector3 lastMouse = new Vector3(255, 255, 255);
    private float totalRun = 1.0f;
    private Rigidbody rigidBodyCam;
		public AudioSource audi;
		private int run = 0;
		public Text Begin;
		private float alpha = 0;

    void Start()
    {
        rigidBodyCam = GetComponent<Rigidbody>();
				StartCoroutine(Fade());
    }
    void FixedUpdate()
    {
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
        Vector3 p = GetBaseInput();
        if (Input.GetKey(KeyCode.LeftShift))
        {
					if(run == 0)
					{
						audi.Play();
						run = 30;
					}
					else if (run > 0)
						run -= 1;

            totalRun += Time.deltaTime;
            p = p * totalRun * shiftAdd;
            p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
            p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
            p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
        }
        else
        {
            totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
            p = p * mainSpeed;
        }
        p = p * Time.deltaTime;
        Vector3 newPosition = transform.position;
        transform.Translate(p);
        newPosition.x = transform.position.x;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
        rigidBodyCam.velocity = Vector3.zero;
        rigidBodyCam.angularVelocity = Vector3.zero;
    }
    private Vector3 GetBaseInput()
    {
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
            p_Velocity += new Vector3(0, 0, 1);
        if (Input.GetKey(KeyCode.S))
            p_Velocity += new Vector3(0, 0, -1);
        if (Input.GetKey(KeyCode.A))
            p_Velocity += new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.D))
            p_Velocity += new Vector3(1, 0, 0);
        return p_Velocity;
    }
    void OnCollisionEnter(Collision col)
    {
        transform.Translate(Vector3.zero);
    }

		private IEnumerator Fade()
		{
			while(alpha < 1)
			{
				alpha += 0.005f;
				Begin.color = new Color(1,1,1, alpha);
				yield return null;
			}
			yield return new WaitForSeconds(2);
			StartCoroutine(FadeOut());
		}

		private IEnumerator FadeOut()
		{
			while(alpha > 0)
			{
				alpha -= 0.005f;
				Begin.color = new Color(1,1,1, alpha);
				yield return null;
			}
		}
}
