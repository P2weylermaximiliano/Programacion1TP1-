using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBala : MonoBehaviour
{
    public int damageAmount = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.name);
        HPEnemigo enemyHP = collision.GetComponent<HPEnemigo>();
        if (enemyHP != null)
        {
            Debug.Log("Enemigo encontrado, aplicando daño.");
            enemyHP.TakeDamageE(damageAmount);
             
        }
    }
}
