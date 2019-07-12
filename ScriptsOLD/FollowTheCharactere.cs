using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheCharactere : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Wall;
    // Update is called once per frame
    void Update()
    {
        Wall.transform.position = new Vector2(rb.position.x - 20, 0);
    }
}
