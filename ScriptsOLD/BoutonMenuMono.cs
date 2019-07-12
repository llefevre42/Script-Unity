using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoutonMenuMono : MonoBehaviour
{
     public GameObject DeathPanel;
    public AudioSource audioSource;
    public GameObject cheat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 public void replay()
    {
        DeathPanel.SetActive(false);
        Application.LoadLevel("GH-beginner");
        Time.timeScale = 1;

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
    }
}
