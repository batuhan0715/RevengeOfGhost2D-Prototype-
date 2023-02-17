using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleltParticle : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = bullet.transform.position;
    }
}
