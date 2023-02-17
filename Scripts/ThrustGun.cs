using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustGun : MonoBehaviour
{
    public float thrustPower;
    Rigidbody2D rb;
    GameObject akParent;

    [SerializeField] ParticleSystem shootParticle;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject.Find("ParentAk");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shootParticle.Play();
            
            Debug.Log("forward" + transform.right);
            Debug.Log("ATES");
            rb.velocity = Vector3.zero;
            rb.AddForce(-transform.right * thrustPower,ForceMode2D.Impulse);
        }

        if(Input.GetMouseButtonUp(0))
        {
            shootParticle.Stop();
        }
    }
}
