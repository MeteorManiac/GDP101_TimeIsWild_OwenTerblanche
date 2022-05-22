using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPf;
    public float bulletforce = 20f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        // Ray ray = new Ray(transform.position,transform.forward);
        // RaycastHit hit;

        // if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .if, collisionMask))
        // {
        //     Vector3 reflectDir = Vector.Reflect(ray.direction, hit.normal);
        //     float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
        //     transform.eulerAngles = new Vector3(0, rot, 0);
        // }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPf, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
