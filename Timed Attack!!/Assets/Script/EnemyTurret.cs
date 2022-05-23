using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
    public Transform playerTank;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction = playerTank.position - transform.position;
       float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg-90;
       rb.rotation = angle;
    }
}
