using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ThiefScript : MonoBehaviour
{
    public bool thiefDestroyed;
    GameObject player;
    public static float thiefHealth = 10;
    Animator thiefAnimation;
    void Start()
    {
        thiefDestroyed = false;
        player = GameObject.FindGameObjectWithTag("Player");
        thiefAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < 30)
        {
            thiefAnimation.SetBool("isAttack", true);

            
        }


        if (distance > 30)
        {
            thiefAnimation.SetBool("isAttack", false);


        }

        if(thiefHealth == 0)
        {
            Destroy(this.gameObject);
            thiefDestroyed = true;
        }

        if(thiefHealth != 0)
        {
            thiefDestroyed = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            thiefHealth -= 2;
            
        }
    }

}
