using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour {
	public GameObject corp;
	public GameObject canonT;
	public GameObject cam;
	public GameObject gunShot;
	public GameObject Boom;
	public AudioSource audi;
	public AudioSource audi2;
	private int stock = 8;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
				int layerMask = 1 << 8;
        layerMask = ~layerMask;
				  RaycastHit hit;
			canonT.transform.position = new Vector3(corp.transform.position.x, corp.transform.position.y + 1.5f, corp.transform.position.z);
//		canonT.transform.rotation = new Quaternion(canonT.transform.rotation.x, cam.transform.rotation.y, canonT.transform.rotation.z,canonT.transform.rotation.w );
			transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 252);

			if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
			{
				audi.Play();
					GameObject shot = Instantiate(gunShot, hit.point, Quaternion.identity);
          ParticleSystem.EmissionModule shotParticles = shot.GetComponent<ParticleSystem>().emission;
          shotParticles.enabled = true;
					Destroy(shot, 1);
			}
			if (Input.GetMouseButtonDown(1) && Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask) && stock > 0)
			{
				audi2.Play();
					GameObject shot = Instantiate(Boom, hit.point, Quaternion.identity);
          ParticleSystem.EmissionModule shotParticles = shot.GetComponent<ParticleSystem>().emission;
          shotParticles.enabled = true;
					Destroy(shot, 1);
					stock--;
			}
		}
	}
