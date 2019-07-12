using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollider : MonoBehaviour
{
    public GameObject proj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject TargetedParticle)
    {
        Destroy(proj);
    }
}
