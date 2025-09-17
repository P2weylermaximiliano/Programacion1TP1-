using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 2f;

    private void Start()
    {
        Destroy(gameObject, lifeTime); 
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); 
        
    }
}
