using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelMono : MonoBehaviour
{
   
    public GameObject DeathPanel;
    public AudioSource audioSource;

    // Start is called before the first frame update
    public void TruePanel()
    {

        if(!(DeathPanel.activeSelf))
        {
            DeathPanel.SetActive(true);
            Time.timeScale = 0;
            audioSource.Pause();
        }
        else
        {
            DeathPanel.SetActive(false);
            Time.timeScale = 1;
            audioSource.Play();
        }
    }
}
