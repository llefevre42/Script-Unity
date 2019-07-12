using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChutePieceNH : MonoBehaviour
{
    public GameObject HitGreen;
   public GameObject HitRed;
   public GameObject HitBlue;
   public GameObject HitYellow;
   public GameObject HitSpace;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
   public GameObject Spot1;
   public GameObject Spot2;
   private GameObject MyGreen;
   private GameObject MyRed;
   private GameObject MyBlue;
   private GameObject MyYellow;
   private GameObject Myspace;
   private GameObject MySpot1;
   private GameObject MySpot2;
   public GameObject fondNoir;
   public GameObject fondGris;
  public GameObject fondNoir2;
   public GameObject fondGris2;
   private double[] section;
   private double[] cuts;
   private double[] fx0;
   private double[] fx1;
   private int retardateur;
   private int i = 0;
   private int m;
   private int j;
   private int k;
   private int h;
   private float rand;

   void Awake()
    {
        section = new double[ PlayerPrefs.GetInt("sectionLength")];
        for(int z = 0; z < PlayerPrefs.GetInt("sectionLength"); z++)
            section[z] = PlayerPrefs.GetInt("section"+z);
    cuts = new double[PlayerPrefs.GetInt("cutsLength")];
     for(int x = 0; x < PlayerPrefs.GetInt("cutsLength"); x++)
            cuts[x] = PlayerPrefs.GetFloat("cuts"+x);

    if(0 == PlayerPrefs.GetInt("song"))
    {
        audioSource1.Play();
    }
    else
    {
        audioSource2.Play();
    }

    }
    void Update()
    {
        if ((m + 5 < cuts.Length) &&  (cuts[m + 4] - ((cuts[m] + cuts[m + 1] + cuts[m + 2] + cuts[m + 3] + cuts[m + 4]) / 5) < 1 ) && retardateur == 0)
        {
             StartCoroutine(MakeSpot());
            retardateur = 5;
        }
        if( m < cuts.Length && ((audioSource1.time + 1.7 > cuts[m] && 0 == PlayerPrefs.GetInt("song")) || (audioSource2.time + 1.7 > cuts[m] && 1 == PlayerPrefs.GetInt("song"))))
        {
            rand = Random.Range(0F,4F);
            if(rand >= 0 && rand < 1)
            MyGreen = (GameObject)Instantiate(HitGreen, new Vector2( -3.3f , 5.33f ), Quaternion.identity);
            if(rand >= 1 && rand < 2)
            MyRed = (GameObject)Instantiate(HitRed, new Vector2( -1.11f , 5.33f ), Quaternion.identity);
            if(rand >= 2 && rand < 3)
            MyBlue = (GameObject)Instantiate(HitBlue, new Vector2( 1.10f , 5.33f ), Quaternion.identity);
             if(rand >= 3 && rand <= 4)
            MyYellow = (GameObject)Instantiate(HitYellow, new Vector2( 3.25f , 5.33f ), Quaternion.identity);

            m++;
            if(retardateur > 0)
            retardateur--;
        }
        if(j < section.Length && ((audioSource1.time + 1.7 > cuts[j] && 0 == PlayerPrefs.GetInt("song")) || (audioSource2.time + 1.7 > cuts[j] && 1 == PlayerPrefs.GetInt("song"))))
        {
            if(i == 0)
            i = 1;
            else
            {
                i = 0;
            } 
            if (i == 1){
            fondGris.GetComponent<Renderer> ().material.color = new Color(0.1f, 0.1f, 0.1f);
            fondNoir.GetComponent<Renderer> ().material.color = new Color(0.7f, 0.7f, 0.7f);
            fondGris2.GetComponent<Renderer> ().material.color = new Color(0.1f, 0.1f, 0.1f);
            fondNoir2.GetComponent<Renderer> ().material.color = new Color(0.7f, 0.7f, 0.7f);
            }
            if (i == 0)
            {
            fondNoir.GetComponent<Renderer> ().material.color = new Color(0.1f, 0.1f, 0.1f);
            fondGris.GetComponent<Renderer> ().material.color = new Color(0.7f, 0.7f, 0.7f);
            fondNoir2.GetComponent<Renderer> ().material.color = new Color(0.1f, 0.1f, 0.1f);
            fondGris2.GetComponent<Renderer> ().material.color = new Color(0.7f, 0.7f, 0.7f);
            }
            j += 2;
        }
    }
     IEnumerator MakeSpot()
     {
        yield return new WaitForSeconds(1.7f);
        MySpot1 = (GameObject)Instantiate(Spot1, new Vector3(4.66f , 4.91f, - 5 ), Spot1.transform.rotation);
        MySpot2 = (GameObject)Instantiate(Spot2, new Vector3(-4.36f , 4.91f, -5 ), Spot2.transform.rotation);
     }
}
