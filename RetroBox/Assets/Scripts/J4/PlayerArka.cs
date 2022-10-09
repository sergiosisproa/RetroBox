using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArka : MonoBehaviour
{
    public float velocidades = 1f;

    private Rigidbody2D rigibody;

    private Vector2 direccion;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rigibody.velocity = new Vector2( x * velocidades, 0);
    }

    
}
