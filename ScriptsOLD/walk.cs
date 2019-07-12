using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    public  AudioSource m_MyAudioSource;
    private Vector2 startPosition;
    private Vector2 endPosition;
    private float swipeDistanceThreshold = 50;

    // Start is called before the first frame update
    void Start()
    {
        SetVelocity(vitesse, 0);
    }
    void Update()
    {
       //  if ((Input.GetKeyDown("space") && isGround) || ((Input.touchCount > 0) && isGround))
     //     {
       //         jump();
         //       }
        //}
         if (Input.GetKeyDown(KeyCode.UpArrow) && rb.position.y < 1)
         {
            rb.position += new Vector2(0, +3);
         }
           if (Input.GetKeyDown(KeyCode.DownArrow) && rb.position.y > -3)
         {
            rb.position += new Vector2(0, -3);
         }
     if (Input.touchCount == 1)
        {
            var touch = Input.touches[0];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPosition = touch.position;
                    break;
                case TouchPhase.Ended:
                     endPosition = touch.position;
                     AnalyzeGesture(startPosition, endPosition);
                    break;
            }
         }
    }
    private void AnalyzeGesture(Vector2 start, Vector2 end)
    {
       if (Vector2.Distance(start, end) > swipeDistanceThreshold)
        {
            if(start.y < end.y && rb.position.y < 1)
            {
                rb.position += new Vector2(0, +3);
            }
            if(start.y > end.y && rb.position.y > -3)
            {
                rb.position += new Vector2(0, -3);
            }
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
