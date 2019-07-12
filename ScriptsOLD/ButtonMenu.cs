using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
     private void Start() 
     {
     }
    public void Runner ()
    {
        Application.LoadLevel("Runner");
        Time.timeScale = 1;
    }
    public void jumper ()
    {
        Application.LoadLevel("Jumper");
        Time.timeScale = 1;
    }
     public void Home ()
    {
        Application.LoadLevel("menu teste");
        Time.timeScale = 1;
    }
     public void guitarHero ()
    {
        Application.LoadLevel("guitarHero");
        Time.timeScale = 1;
    }
    public void guitarHeroNH()
    {
        Application.LoadLevel("GH-noHit");
        Time.timeScale = 1;
    }
    public void GHrules()
    {
        Application.LoadLevel("GH-rules");
        Time.timeScale = 1;
    }
 public void RunnerRules()
    {
        Application.LoadLevel("Runner-rules");
        Time.timeScale = 1;
    }
    public void SelectLevel()
    {
        Application.LoadLevel("SelectLevelGH");
        Time.timeScale = 1;
    }
    
}
