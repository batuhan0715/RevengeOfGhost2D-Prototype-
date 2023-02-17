using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotation : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        transform.eulerAngles = Vector3.zero;
    }
}
