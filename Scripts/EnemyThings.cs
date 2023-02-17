using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class EnemyThings : MonoBehaviour
{
    public bool isDestroyed;

    Animator priestAnimation;

    public GameObject monsterBullet;
    public Transform enemyHitPoint;
    float timer;
    GameObject player;
    static float health = 10;
    void Start()
    {
        isDestroyed = false;
        priestAnimation = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
       
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance<100)
        {
            timer += Time.deltaTime;
            if(timer > 4)
            {
                
                
                timer = 0;
                shoot();
            }
           
            if(timer > 3.68f)
            {
                priestAnimation.SetBool("isAttack", true);
            }
            
            if(timer < 3.68f)
            {
                priestAnimation.SetBool("isAttack", false);
            }
           

        }


        if (health == 0f)
        {
            isDestroyed = true;
            Destroy(this.gameObject);

        }

        if (health != 0f)
        {
            isDestroyed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            health -= 2f;
            
        }
        

    }

    void shoot()
    {
        Instantiate(monsterBullet, enemyHitPoint.position, enemyHitPoint.rotation);
        
    }

   
}
