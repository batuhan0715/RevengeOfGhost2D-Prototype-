using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource src;
    public AudioClip hitSound;
    void Start()
    {
        src.clip = hitSound;
        
    }

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            src.Play();
        }
    }
}
