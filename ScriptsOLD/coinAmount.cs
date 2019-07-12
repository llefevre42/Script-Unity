using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinAmount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //    gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") + "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")) 
        {
            Debug.Log("Tresor sauvegarder");
            PlayerPrefs.SetInt("CoinAmount", int.Parse(gameObject.GetComponent<Text>().text));
         }
    }
}
