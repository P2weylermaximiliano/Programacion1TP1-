using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos1 : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigoPrefab;
     [SerializeField]
    private int quantityEnemies = 5;
    private float timer = 0f;
    private int enemigosSpawned = 0;
    
    
    
    void Update()
    {
        if (enemigosSpawned < quantityEnemies)
        {
            timer += Time.deltaTime;
            if (timer >= 2f)
            {
                Instantiate(enemigoPrefab, transform.position, Quaternion.identity);
                enemigosSpawned++;
                timer = 0f;
            }
        }
    }

    
    
}
