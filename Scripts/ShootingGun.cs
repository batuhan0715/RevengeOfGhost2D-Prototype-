using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            ShootGun();
        }
    }

    void ShootGun()
    {
        
        
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        

    }    
}
