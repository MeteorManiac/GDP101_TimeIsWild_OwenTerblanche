using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerTank").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection= direction;
        }
    }
}
