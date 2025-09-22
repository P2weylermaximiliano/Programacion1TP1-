using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    [SerializeField]
    public float speed = 2f;
    [SerializeField]
    List<Vector3> puntos = new List<Vector3>();
    Vector3 direccion; 
    private int indiceActual = 0;

    void Update()
    {
        if (puntos.Count == 0) return;

        Vector3 destino = puntos[indiceActual];
        direccion = destino - transform.position;

        if (direccion.magnitude > 0.1f)
        {

            transform.position += direccion.normalized * speed * Time.deltaTime;
        }
        else
        {
            if (indiceActual < puntos.Count - 1)
            {
                indiceActual++;
            }

        }
    }
    
}
