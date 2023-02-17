using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    float walkHor;
    public float walkSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        walkHor = Input.GetAxisRaw("Horizontal");
        //Movement();
    }

   

    void Movement()
    {
        transform.Translate(new Vector2(walkHor * walkSpeed * Time.deltaTime, 0));
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Ground"))
        {
            Movement();
        }
    }



}
