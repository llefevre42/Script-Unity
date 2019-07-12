using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finalScore : MonoBehaviour
{
   public AudioSource audioSource;
     public AudioSource audioSource2;
    public GameObject FinalScorePanel;
    public Text UI;
    public Text texte;
    private void Update() 
    {
        Debug.Log("pasfini");
        if(audioSource.time + 3 >= audioSource.clip.length + 2 || audioSource2.time + 3  >= audioSource2.clip.length + 2)
        {
            FinalScorePanel.SetActive(true);
            Debug.Log("fini");
            texte.text = UI.text;
            Time.timeScale = 0;
            if(0 == PlayerPrefs.GetInt("song"))
                audioSource.Pause();
            else
                audioSource2.Pause();
        }
    }
}
