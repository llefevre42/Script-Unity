using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheShadowsssss : MonoBehaviour {
public AudioSource audioSource;

void Start()
 {
         audioSource.time = 59.0f;   // assuming that you already have reference to your AudioSource
         audioSource.Play();
 }
}