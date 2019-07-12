using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour {
	private int i;
	public Vector3 currentWaypoint;
	public GameObject tank;
	private int call = 1;
	public GameObject gunShot;
	public GameObject canon;
	private int cooldown;
	private float tmp2;
	public AudioSource audi;
	public AudioSource audi2;
	// Use this for initialization
	void Start () {
		currentWaypoint = new Vector3(5000, 5000, 5000);
			Collider[] hitColliders = Physics.OverlapSphere(transform.position, 500);
		while(i < hitColliders.Length)
		{
			if(hitColliders[i].tag == "Player")
			{
				if(Vector3.Distance(tank.transform.position , currentWaypoint) > Vector3.Distance(tank.transform.position , hitColliders[i].transform.position))
				{
					if( 5 < Vector3.Distance(tank.transform.position , hitColliders[i].transform.position))
						currentWaypoint = hitColliders[i].transform.position;}
			}
			i++;
		}
}
	// Update is called once per frame
	void FixedUpdate ()
	{
		int layerMask = 1 << 8;
		layerMask = ~layerMask;
			RaycastHit hit;
				i = 0;
				Vector3 tmp =	currentWaypoint;
				tmp.y += 1;
				canon.transform.LookAt(tmp);

				currentWaypoint = new Vector3(5000, 5000, 5000);
				Collider[] hitColliders = Physics.OverlapSphere(transform.position, 500);
				while(i < hitColliders.Length)
				{
					if(hitColliders[i].tag == "Player")
					{
						if(Vector3.Distance(tank.transform.position , currentWaypoint) > Vector3.Distance(tank.transform.position , hitColliders[i].transform.position))
						{
							if( 5 < Vector3.Distance(tank.transform.position , hitColliders[i].transform.position))
								currentWaypoint = hitColliders[i].transform.position;}
					}
					i++;
				}
				GetComponent<NavMeshAgent>().destination = currentWaypoint;
				if(Physics.Raycast(canon.transform.position, canon.transform.TransformDirection(Vector3.forward), out hit, 40))
				{

					GetComponent<NavMeshAgent>().destination = tank.transform.position;
					if(cooldown == 0)
					{
						tmp2 = Random.Range(0, 2);
						Debug.Log(tmp2);
						if(tmp2 < 0.5f)
						{
								audi.Play();
								GameObject shot = Instantiate(gunShot, hit.point, Quaternion.identity);
								ParticleSystem.EmissionModule shotParticles = shot.GetComponent<ParticleSystem>().emission;
								shotParticles.enabled = true;
								Destroy(shot, 1);
						}
						else
						{
								audi2.Play();
							GameObject shot = Instantiate(gunShot, new Vector3(hit.point.x + 3,hit.point.y,hit.point.z), Quaternion.identity);
							ParticleSystem.EmissionModule shotParticles = shot.GetComponent<ParticleSystem>().emission;
							shotParticles.enabled = true;
							Destroy(shot, 1);
						}
						cooldown = 50;

					}
					else
					{
						if(cooldown > 0)
							cooldown -= 1;
					}
				}

	}
}
