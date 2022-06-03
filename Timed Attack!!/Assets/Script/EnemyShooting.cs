using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    
     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<PlayerTankControlls>();
            player.Kill();
            Destroy(gameObject, 5);
        }
    }
}