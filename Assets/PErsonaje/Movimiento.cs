using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] 
    Rigidbody2D rb;
    [SerializeField] 
    private float speed=5f;
    Vector3 direction;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Horizontal");
        float y=Input.GetAxis("Vertical");
        direction = new Vector3(x, y);
        
       
        

    }
    private void FixedUpdate()
    {
        
        rb.MovePosition(transform.position +Vector3.ClampMagnitude(direction,1) * speed * Time.fixedDeltaTime);
    }
}
