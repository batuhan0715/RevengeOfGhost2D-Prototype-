using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTakeHit : MonoBehaviour
{
    
   
    public Image healthBarr;
    float timer;
    static float playerHealth = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        


        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            playerHealth -= 25;
            healthBarr.fillAmount = playerHealth / 100;
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Thief"))
        {
               
                    playerHealth -= 25 * Time.deltaTime;

                    healthBarr.fillAmount = playerHealth / 100;
                
            
        }
    }


}
