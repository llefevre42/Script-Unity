using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPanel : MonoBehaviour
{
    public GameObject DeathPanel;
    public AudioSource audioSource;
     public AudioSource audioSource2;

    // Start is called before the first frame update
    public void TruePanel()
    {

        if(!(DeathPanel.activeSelf))
        {
            DeathPanel.SetActive(true);
            Time.timeScale = 0;
            if(0 == PlayerPrefs.GetInt("song"))
                audioSource.Pause();
            else
                audioSource2.Pause();
        }
        else
        {
            DeathPanel.SetActive(false);
            Time.timeScale = 1;
             if(0 == PlayerPrefs.GetInt("song"))
                audioSource.Play();
            else
                audioSource2.Play();
        }
    }
}
