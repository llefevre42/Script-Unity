using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyNote : MonoBehaviour
{
    public float value = 1;
    public GameObject UI;
    public GameObject combo;
    public AudioSource Down;
    public GameObject Mute;
    // Start is called before the first frame update
    void Start()
    {
         UI = GameObject.FindGameObjectWithTag("CoinAmount");
         combo = GameObject.FindGameObjectWithTag("combo");
         Mute = GameObject.FindGameObjectWithTag("Mute");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Obstacle"))
        {
            if(0 == int.Parse(Mute.GetComponent<Text>().text))
                Down.Play();
            float coinUI = float.Parse(UI.GetComponent<Text>().text) - value;
            UI.GetComponent<Text>().text = coinUI + "";
            float comboUI = float.Parse(combo.GetComponent<Text>().text) * 0;
            combo.GetComponent<Text>().text = comboUI + "";
            Destroy(gameObject);
        }
    }
}
