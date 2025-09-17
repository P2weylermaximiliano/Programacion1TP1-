using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);
        HP HPplayer = collision.gameObject.GetComponent<HP>();
        if (HPplayer != null)
        {
            HPplayer.TakeDamage(damage);
        }
    }
}
