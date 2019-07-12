using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpButton : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void jumpUp()
        {
            if ( rb.position.y < 1)
            {
                rb.position += new Vector2(0, +3);
            }
            
        }
        public void jumpDown()
        {
    if (rb.position.y > -3)
            {
                rb.position += new Vector2(0, -3);
            }
        }
}
