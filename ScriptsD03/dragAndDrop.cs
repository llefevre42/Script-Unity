using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public GameObject objectCanon;
	public GameObject CostCanon;
	public GameObject data;
	public Camera cam;
	private Ray clicked;
	private Vector3 originCanon;
	private Vector3 originMitra;
	private Vector3 originMissile;
	private int itsOk;

	void Start ()
	{
		data.GetComponent<gameManager>().playerEnergy = 300;
	}

	void Update ()
	{
		if(data.GetComponent<gameManager>().playerEnergy >= CostCanon.GetComponent<towerScript>().energy)
		{
			itsOk = 1;
		}
		else
			itsOk = 0;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		originCanon = objectCanon.transform.position;
	//	originMitra = objectMitra.transform.position;
	//	originMissile = objectMissile.transform.position;
	}
	// Update is called once per frame
	public void OnDrag(PointerEventData data)
	{

			if(itsOk == 1)
			{
				clicked = cam.ScreenPointToRay(Input.mousePosition);
				objectCanon.transform.position = new Vector3(clicked.origin.x ,clicked.origin.y , -1);
			}
		}

	public void OnEndDrag(PointerEventData eventData)
	{
		if(itsOk == 1)
		{
			RaycastHit2D empty = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if(empty && empty.collider.gameObject.tag == "empty")
			{
					GameObject newTower = Instantiate(CostCanon, empty.collider.gameObject.transform.position, empty.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= CostCanon.GetComponent<towerScript>().energy;
					Destroy(empty.collider.gameObject);
			}
			objectCanon.transform.position = originCanon;
		}
	}
}
