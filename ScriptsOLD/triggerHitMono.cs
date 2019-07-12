using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerHitMono : MonoBehaviour
{
   
    public KeyCode key;
    bool active = false;
    GameObject note;
    public float value;
    public GameObject UI;

    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("CoinAmount");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key) && active)
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
        float coinUI = float.Parse(UI.GetComponent<Text>().text) + value;
        UI.GetComponent<Text>().text = coinUI + "";
        Destroy(note);
    }
}
