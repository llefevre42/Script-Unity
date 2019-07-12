using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteButton : MonoBehaviour
{
     public GameObject Mute;
    // Start is called before the first frame update
    void Start()
    {
        Mute = GameObject.FindGameObjectWithTag("Mute");
    }
    public void ButtMute()
    {
       
        if(0 == int.Parse(Mute.GetComponent<Text>().text))
            {
                Mute.GetComponent<Text>().text = 1 + "";
            }
        else
        {
            Mute.GetComponent<Text>().text = 0 + "";
        }
        
    }
}
