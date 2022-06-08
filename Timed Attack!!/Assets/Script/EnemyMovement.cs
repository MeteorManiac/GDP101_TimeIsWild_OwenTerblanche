using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player, shootPos;
    public Transform[] points;
    private float waitTime;
    public float startWaitTime;
    
    int picker;
    private float dist2player;
    
    public float speed, range, timeBetweeShots, shootSpeed;
    public GameObject EnBullet;
    private bool canShoot;
    public Transform shootPoint;
    public GameObject bulletPf;
    public float bulletforce = 3f;

    
    void Start()
    {
        waitTime = startWaitTime;
        picker = Random.Range(0, points.Length);    
        canShoot = true;
    }

    void Update()
    {
        if(canShoot)
        {
        StartCoroutine(Shoot());
        }
       transform.position = Vector2.MoveTowards(transform.position, points[picker].position, speed * Time.deltaTime);
       
    //    Vector3 relativePosition = points.position - transform.position;
    //    transform.rotation = Quaternion.LookRotation (relativePosition);

       if(Vector2.Distance(transform.position, points[picker].position)< 0.2f)
       {
           if(waitTime <= 0)
           {
               picker = Random.Range(0, points.Length); 
               waitTime = startWaitTime;
           }
           else
           {
               waitTime -= Time.deltaTime;
           }
       }
    }

    public void Kill()
    {
       ScoreManager.instance.AddPoint();
       Destroy(gameObject);
       Debug.Log("You Win");
    }

    IEnumerator Shoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(timeBetweeShots);
        GameObject bullet = Instantiate(bulletPf, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletforce, ForceMode2D.Impulse);
        canShoot = true;
    }
}