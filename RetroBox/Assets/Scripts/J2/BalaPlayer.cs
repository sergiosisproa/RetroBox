using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    public Vector3 direccion;
    public float velocidad;
    public System.Action destruido;

    private void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        this.transform.position += this.direccion * this.velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.destruido.Invoke();
        Destroy(this.gameObject);
    }
}
