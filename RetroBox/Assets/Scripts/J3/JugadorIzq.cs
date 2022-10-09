using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorIzq : MonoBehaviour
{
    public float velocidad = 1f;

    private Rigidbody2D rigibody;

    private Vector2 direccion;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movimiento();

        if (direccion.sqrMagnitude != 0)
        {
            rigibody.AddForce(direccion * velocidad);
        }
    }

    void Movimiento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direccion = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direccion = Vector2.down;
        }
        else
        {
            direccion = Vector2.zero;
        }
    }
}
