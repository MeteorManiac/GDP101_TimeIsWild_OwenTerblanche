using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    
    void OnCollisionEnter2D(Collision2D walls)
    {
        
    }

     IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
