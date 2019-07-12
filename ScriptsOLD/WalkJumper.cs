using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkJumper : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool isGround = false;
    public GameObject DeathPanel;
    public  AudioSource m_MyAudioSource;
    //private float x = -500;

    // Start is called before the first frame update
    void Start()
    {
        SetVelocity(vitesse, 0);
        DeathPanel.SetActive(false);
    }
    void Update()
    {
       if (Input.GetKeyDown("space") /*&& isGround*/)
         {
              jump();
        }
        
     /*    if(rb.transform.position.x > x )
            x = rb.transform.position.x;
        else
        {
             DeathPanel.SetActive(true);
        }*/
    }
    public void jump()
    {
        rb.velocity += new Vector2(0, maxJump);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")) 
        {
            isGround = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
    void SetVelocity(float xvelocity, float yvelocity)
    {
        rb.velocity = new Vector2(0, 0);
        rb.velocity += new Vector2(xvelocity, yvelocity);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(ObstacleFind());
        }
    }
    IEnumerator ObstacleFind()
    {
       m_MyAudioSource.volume = 1f;
       for(int i = 0; i < 9 ; i++)
       {
        yield return new WaitForSeconds(0.05f);
           m_MyAudioSource.volume -= 0.1f;
       }
    }
}
