using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] points;
    private float waitTime;
    public float startWaitTime;
    
    int picker;
    
    public float speed;
    
    void Start()
    {
        waitTime = startWaitTime;
        picker = Random.Range(0, points.Length);    
    }

    void Update()
    {
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
}