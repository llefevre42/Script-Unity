using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerHit : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    public float value;
    public GameObject UI;
    public GameObject combo;
    public GameObject cheat;
    public GameObject Mute;
    public AudioSource Up;
    public GameObject Spot;
    private GameObject MySpot;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("CoinAmount");
        combo = GameObject.FindGameObjectWithTag("combo");
        cheat = GameObject.FindGameObjectWithTag("cheat");
        Mute = GameObject.FindGameObjectWithTag("Mute");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key) && active)
        {
           PointCombo();
        }
        if(1 == int.Parse(cheat.GetComponent<Text>().text) && active)
        {
            PointCombo();
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if(col.gameObject.tag=="Note")
            note=col.gameObject;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        active = false;
    }
    public void ButtonPress()
    {
        if(active){
            PointCombo();
        }
    }
    private void PointCombo()
    {

        if(0 == int.Parse(Mute.GetComponent<Text>().text))
        {
            Up.Play();
        }
        MySpot = (GameObject)Instantiate(Spot);
        value += 0.1f * float.Parse(combo.GetComponent<Text>().text);
        float coinUI = float.Parse(UI.GetComponent<Text>().text) + value;
        value = 1;
        UI.GetComponent<Text>().text = coinUI + "";
        float comboUI = float.Parse(combo.GetComponent<Text>().text) + 1;
        combo.GetComponent<Text>().text = comboUI + "";
        Destroy(note);
      
    }

}
