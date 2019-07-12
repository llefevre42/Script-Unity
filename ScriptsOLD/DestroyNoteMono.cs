using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyNoteMono : MonoBehaviour
{
    public float value = 1;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
         UI = GameObject.FindGameObjectWithTag("CoinAmount");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Obstacle"))
        {
            float coinUI = float.Parse(UI.GetComponent<Text>().text) - value;
            UI.GetComponent<Text>().text = coinUI + "";
            Destroy(gameObject);
        }
    }
}
