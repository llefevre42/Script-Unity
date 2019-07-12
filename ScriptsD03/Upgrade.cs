using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {
	public Camera cam;
	public GameObject UpgradePanel;
	public GameObject data;
	public GameObject Canon1;
	public GameObject Canon2;
	public GameObject Canon3;
	public GameObject Mitra1;
	public GameObject Mitra2;
	public GameObject Mitra3;
	public GameObject Roket1;
	public GameObject Roket2;
	public GameObject Roket3;
	public GameObject Sol;
	private RaycastHit2D tower;
	public GameObject upgradeText;
	public GameObject sellText;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
			if(Input.GetMouseButtonDown(1) && UpgradePanel.transform.position.x > 200)
			{
				tower = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
				if(tower && tower.collider.gameObject.tag == "tower")
				{
					UpgradePanel.transform.position = new Vector3(tower.collider.gameObject.transform.position.x, tower.collider.gameObject.transform.position.y, 0);
				}
				upgradeText.GetComponent<Text>().text = tower.collider.gameObject.transform.parent.gameObject.GetComponent<towerScript>().upgrade.GetComponent<towerScript>().energy.ToString();
				sellText.GetComponent<Text>().text = (tower.collider.gameObject.transform.parent.gameObject.GetComponent<towerScript>().energy/2).ToString();
			}
	}
	public void UpgradeTower()
	{
		Debug.Log(tower.collider.gameObject.transform.parent.name);
			if(tower.collider.gameObject.transform.parent.name == "canon_1(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Canon2.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Canon2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Canon2.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}
			if(tower.collider.gameObject.transform.parent.name == "canon_2(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Canon3.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Canon3, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Canon3.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}
			if(tower.collider.gameObject.transform.parent.name == "gatling_1(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Mitra2.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Mitra2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Mitra2.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}
			if(tower.collider.gameObject.transform.parent.name == "gatling_2(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Mitra3.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Mitra3, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Mitra3.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}
			if(tower.collider.gameObject.transform.parent.name == "rocket_1(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Roket2.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Roket2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Roket2.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}
			if(tower.collider.gameObject.transform.parent.name == "rocket_2(Clone)" && data.GetComponent<gameManager>().playerEnergy >= Roket3.GetComponent<towerScript>().energy)
			{
					GameObject newTower = Instantiate(Roket3, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
					data.GetComponent<gameManager>().playerEnergy -= Roket3.GetComponent<towerScript>().energy;
					Destroy(tower.collider.gameObject.transform.parent.gameObject);
			}

				UpgradePanel.transform.position =  new Vector3(UpgradePanel.transform.position.x + 500, UpgradePanel.transform.position.y, UpgradePanel.transform.position.z);
		}
		public void DowngradeTower()
		{
					if(tower.collider.gameObject.transform.parent.name == "canon_2(Clone)")
					{
						GameObject newTower = Instantiate(Canon1, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Canon2.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "canon_3(Clone)")
					{
						GameObject newTower = Instantiate(Canon2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Canon3.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "gatling_2(Clone)")
					{
						GameObject newTower = Instantiate(Mitra1, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Mitra2.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "gatling_3(Clone)")
					{
						GameObject newTower = Instantiate(Mitra2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Mitra3.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "rocket_2(Clone)")
					{
						GameObject newTower = Instantiate(Roket1, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Roket2.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "rocket_3(Clone)")
					{
						GameObject newTower = Instantiate(Roket2, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Roket3.GetComponent<towerScript>().energy / 2);
							Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "canon_1(Clone)")
					{
						GameObject newTower = Instantiate(Sol, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Canon1.GetComponent<towerScript>().energy / 2);
						Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "gatling_1(Clone)")
					{
						GameObject newTower = Instantiate(Sol, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Mitra1.GetComponent<towerScript>().energy / 2);
						Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}
					if(tower.collider.gameObject.transform.parent.name == "rocket_1(Clone)")
					{
						GameObject newTower = Instantiate(Sol, tower.collider.gameObject.transform.position, tower.collider.gameObject.transform.rotation) as GameObject;
						data.GetComponent<gameManager>().playerEnergy += (Roket1.GetComponent<towerScript>().energy / 2);
						Destroy(tower.collider.gameObject.transform.parent.gameObject);
					}

				UpgradePanel.transform.position =  new Vector3(UpgradePanel.transform.position.x + 500, UpgradePanel.transform.position.y, UpgradePanel.transform.position.z);
		}

		public void ClosePannel()
		{
			UpgradePanel.transform.position =  new Vector3(UpgradePanel.transform.position.x + 500, UpgradePanel.transform.position.y, UpgradePanel.transform.position.z);
		}
	//ß	objectCanon.transform.position = originCanon;
}
