using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPf;
    public GameObject bombPf;
    public float bulletforce = 3f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if(Input.GetButtonDown("Fire2"))
        {
            Throw();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPf, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletforce, ForceMode2D.Impulse);
    }
    void Throw()
    {
        GameObject bomb = Instantiate(bombPf, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bomb.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
