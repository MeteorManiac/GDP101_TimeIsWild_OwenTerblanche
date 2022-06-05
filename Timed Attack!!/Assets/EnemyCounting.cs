using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounting : MonoBehaviour
{
    public bool isAllEnemiesDied;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length == 0 && isAllEnemiesDied == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex + 1);
        }

        for(int i = 0; 1 < enemies.Length; i++)
        {
            if(enemies[i] != null && isAllEnemiesDied == false)
            {
                isAllEnemiesDied = false;
            }
        }
    }
}
