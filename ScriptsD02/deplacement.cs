using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour {
	public Camera cam;
	public Ray clicked;
	public GameObject champ;
	private Vector3 screenPos;
	public AudioSource audioMoove;
	public Animator MyAnimator;
	private int waiting;
	private Vector3 dir;
	public int speed;
	public int click = 0;
	public  int actif = 0;

	// Use this for initialization
	void Start ()
	{
		clicked.origin = transform.position;
	}

	void Update ()
	{

	}

	void OnMouseDown()
 	{
		if(Input.GetMouseButtonDown(0))
		{
				 click = 1;
		}
 }
	public void IsClicked()
	{
		audioMoove.Play(0);
		clicked = cam.ScreenPointToRay(Input.mousePosition);
		dir = cam.WorldToScreenPoint(transform.position);
		dir = Input.mousePosition - dir;
	}

	public void Charger ()
	{
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
		transform.position = Vector3.MoveTowards (transform.position, new Vector3(clicked.origin.x ,clicked.origin.y , 0) , speed * Time.deltaTime);
		if(waiting > 0)
			waiting--;
		if(champ.transform.position.x != clicked.origin.x && champ.transform.position.y != clicked.origin.y && waiting == 0)
		{
		 MyAnimator.SetTrigger("run");
		 waiting = 25;
		}
	}
}
