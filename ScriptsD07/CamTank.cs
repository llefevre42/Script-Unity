﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTank : MonoBehaviour {
	[SerializeField]
private Transform target;
[SerializeField]
private Vector3 offsetPosition;
[SerializeField]
private Space offsetPositionSpace = Space.Self;

	void Start()
     {
         Cursor.visible = false;
     }
     private void Update()
     {
         Vector2 scroll = Input.mouseScrollDelta;
         if (scroll.y > 0 && offsetPosition.z < -5)
         {
             if (offsetPosition.z + scroll.y >= -5)
                 offsetPosition = new Vector3(offsetPosition.x, offsetPosition.y, -5);
             else
                 offsetPosition = new Vector3(offsetPosition.x, offsetPosition.y, offsetPosition.z + scroll.y);
         }
         else if (scroll.y < 0 && offsetPosition.z > -25)
         {
             if (offsetPosition.z + scroll.y <= -25)
                 offsetPosition = new Vector3(offsetPosition.x, offsetPosition.y, -25);
             else
                 offsetPosition = new Vector3(offsetPosition.x, offsetPosition.y, offsetPosition.z + scroll.y);
         }
         Refresh();
     }
     public void Refresh()
     {
         if (target == null)
             return;
         if (offsetPositionSpace == Space.Self)
             transform.position = target.TransformPoint(offsetPosition);
         else
             transform.position = target.position + offsetPosition;
         transform.rotation = target.rotation;
     }
 }
