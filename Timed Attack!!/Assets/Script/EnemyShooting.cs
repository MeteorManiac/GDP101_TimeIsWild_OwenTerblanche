using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyShooting : MonoBehaviour
{
    
     private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<PlayerTankControlls>();
            player.Kill();
            SceneManager.LoadScene(1);
        }
    }

    void Start()
    {
        Destroy(gameObject, 5);
    }
}