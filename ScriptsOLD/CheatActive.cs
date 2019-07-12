using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatActive : MonoBehaviour
{
  
    public GameObject DeathPanel;
    public AudioSource audioSource;
     public GameObject cheat;
    void Start()
    {
           cheat = GameObject.FindGameObjectWithTag("cheat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resume()
    {
        DeathPanel.SetActive(false);
        Time.timeScale = 1;
        audioSource.Play();
    }
    public void cheatGH()
    {
        if(0 == int.Parse(cheat.GetComponent<Text>().text))
            {
                cheat.GetComponent<Text>().text = 1 + "";
                resume();
            }
        else
        {
            cheat.GetComponent<Text>().text = 0 + "";
            resume();
        }
        Debug.Log(((cheat.GetComponent<Text>().text)));
    }
}
