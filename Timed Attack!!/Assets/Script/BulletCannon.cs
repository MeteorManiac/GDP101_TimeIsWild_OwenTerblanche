using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCannon : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 8f;
    [SerializeField] float bulletFlyTime = 5f;
    [SerializeField] float firingRate = 0.2f;
    
    public bool isShooting;

    Coroutine shootCoroutine;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (isShooting && shootCoroutine == null)
        {
            shootCoroutine = StartCoroutine(ShootContinuously());
        }
        else if (!isShooting && shootCoroutine !=null)
        {
            StopCoroutine(shootCoroutine);
            shootCoroutine = null;
        }
    }
    IEnumerator ShootContinuously()
    {
        while(true)
        {
            GameObject instance = Instantiate(bullet,transform.position,Quaternion.identity);
            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if(rb !=null)
            {
                rb.velocity = transform.up * bulletSpeed;
            }
            Destroy(instance, bulletFlyTime);
            yield return new WaitForSeconds(firingRate);
        }
    }
}
