using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemigo : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamageE(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            DieE();
        }
    }

    private void DieE()
    {
        Debug.Log("Jugador muerto");
        Destroy(gameObject);
    }
}
