using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1 : MonoBehaviour
{
    public float velocidad = 5;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 4);
    }
    
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        rb.velocity = new Vector2(velocidad, 0);
    }
}
