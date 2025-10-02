using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    [SerializeField] private GameObject torretaPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            Instantiate(torretaPrefab, mousePos, Quaternion.identity);
        }
    }
}
