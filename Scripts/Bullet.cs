using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timerSlowMotion;
    public EnemyThings enemy;
    public ThiefScript thief;
    
    public float slowMotionTimeScale;
    private float startTimeScale;
    private float startFixedDeltaTime;

    [SerializeField] ParticleSystem explosionBullet;
    public Rigidbody2D rb;
    void Start()
    {
        thief = FindObjectOfType<ThiefScript>();
        enemy = FindObjectOfType<EnemyThings>(); 
        
        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
        rb.velocity = transform.right * 7200 * Time.deltaTime;

        StartCoroutine(Destroy());
    }

    
    void Update()
    {
        if(enemy != null)
        {
            if (enemy.isDestroyed == true)
            {
                Debug.Log("dsf");
                StartSlowMotion();
                StartCoroutine(stopslowmo());

            }
        }
       
        if(thief != null)
        {
            if (thief.thiefDestroyed == true)
            {
                Debug.Log("thieflog");
                StartSlowMotion();
                StartCoroutine(stopslowmo());
            }
        }
       
       

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
           
            explosionBullet.Play();
            //Destroy(this.gameObject);
            //Instantiate(explosionBullet, this.transform.position, this.transform.rotation);
        }




    }


    void StartSlowMotion()
    {
        Time.timeScale = slowMotionTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime * slowMotionTimeScale;
    }

    void StopSlowMotion()
    {
        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }

    IEnumerator stopslowmo()
    {
        yield return new WaitForSecondsRealtime(0.8f);
        StopSlowMotion();
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSecondsRealtime(1.7f);
        Destroy(this.gameObject);
    }
}
