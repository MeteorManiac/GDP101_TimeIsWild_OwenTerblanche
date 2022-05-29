using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    // public float Speed = 4;

    // public bool Thrown;

    // public Vector3 LaunchOffset;

    // public GameObject enemyTank;

    // public GameObject speedyTank;

    // public TimeManager timeManager;

    // private void Start()
    // {
    //     if(Thrown)
    //     {
    //     var direction = transform.up;
    //     GetComponent<Rigidbody2D>().AddForce(direction * Speed, ForceMode2D.Impulse);
    //     }
    //     transform.Translate(LaunchOffset);
    //     Destroy(gameObject);
    // }

    // public void Update()
    // {
    //     if(Thrown)
    //     {
    //     transform.position += transform.right * Speed * Time.deltaTime;
    //     }
    // }
    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     var enemy = collision.collider.GetComponent<EnemyMovement>();
    //     if (enemy)
    //     {
    //         
    //         
    //     }
    //     Destroy(gameObject);
    // }

    public float delay = 3f;

    float countdown;
    bool hasExploded = false;
    public TimeManager timeManager;

    void Start()
    {
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Destroy(gameObject);
        timeManager.SlowDown();
    }
}
