using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorCollum : MonoBehaviour
{
    public GameObject Collum;

    public int ChooseColor;
    private float color = 1.0f;
    private int fade = 1;
    private int limite = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (limite < 1)
        {
            limite ++;
        }
        else
        {
            limite = 0;
            if(ChooseColor == 1)
            {
                if(color > 0.4f && fade == 1)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(color, color, 1.0f);
                    color -= 0.01f;
                    if(color <= 0.4f)
                        fade = 0;
                }
                if( color < 1.0f && fade == 0)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(color, color, 1.0f);
                    color += 0.01f;
                    if(color >= 1.0f)
                        fade = 1;
                }
            }
            else if(ChooseColor == 2)
            {
                if(color > 0.4f && fade == 1)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(color, 1.0f, color);
                    color -= 0.01f;
                    if(color <= 0.4f)
                        fade = 0;
                }
                if( color < 1.0f && fade == 0)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(color, 1.0f, color);
                    color += 0.01f;
                    if(color >= 1.0f)
                        fade = 1;
                }
            }
            else
            {
                if(color > 0.4f && fade == 1)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(1.0f, color, color);
                    color -= 0.01f;
                    if(color <= 0.4f)
                        fade = 0;
                }
                if( color < 1.0f && fade == 0)
                {
                    Collum.GetComponent<Renderer> ().material.color = new Color(1.0f, color, color);
                    color += 0.01f;
                    if(color >= 1.0f)
                        fade = 1;
                }
            }
        }
    }
}
