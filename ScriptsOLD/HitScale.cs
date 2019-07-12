using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScale : MonoBehaviour
{
    public GameObject hit;
    private float scale = 1.0f;
    private float aug = 0.01f;

    private int active = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scale < 1.2f && active == 1)
        {
            hit.transform.localScale += new Vector3(aug, aug, 0);
            scale += aug;
        }
        if(scale > 1.0f && active == 0)
        {
            hit.transform.localScale -= new Vector3(aug, aug, 0);
            scale -= aug;
        }
        Debug.Log(hit.transform.localScale);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        active = 1;
   //     if(col.gameObject.tag=="Note")
     //       note=col.gameObject;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        active = 0;
    }
}
