using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour {

	public List<Vector3> waypoints;
	public Vector3 currentWaypoint;
	public int lastWaypoint = 0;
	// Use this for initialization
	void Awake ()
	{
			currentWaypoint = waypoints[lastWaypoint++];
			GetComponent<NavMeshAgent>().destination = currentWaypoint;
	}

	// Update is called once per frame
	void Update ()
	{
		if(Vector3.Distance(transform.position, currentWaypoint) <= 0.5f)
		{
			if(lastWaypoint != waypoints.Count)
				currentWaypoint = waypoints[lastWaypoint++];
			else
			{
				lastWaypoint = 0;
				currentWaypoint = waypoints[lastWaypoint++];
			}
			GetComponent<NavMeshAgent>().destination = currentWaypoint;
		}
	}
}
