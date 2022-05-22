using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(SelfDestruct());
    }

     IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }

          void OnCollisionEnter(Collision collision)
    {
        Vector3 v = Vector3.Reflect(transform.up, collision.contacts[0].normal);
        float rot = 90 - Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(90, rot, 0);
    }
}
