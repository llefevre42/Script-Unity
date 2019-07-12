using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalScoreMono : MonoBehaviour
{
     public AudioSource audioSource;
    public GameObject FinalScorePanel;
    public Text UI;
    public Text texte;
    private void Update() 
    {
        Debug.Log("pasfini");
        if(audioSource.time + 3 >= audioSource.clip.length + 2)
        {
            FinalScorePanel.SetActive(true);
            Debug.Log("fini");
            texte.text = UI.text;
            Time.timeScale = 0;
            audioSource.Pause();

        }
    }
}
