using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaFragoneta : MonoBehaviour
{
    public int velocidad = 1;
    int direccion = 1;
    int limiteSuperior = 4;
    int limiteInferior = -4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        // ACCIONES DEPENDIENDO DEL ESTADO
        if (direccion == 1)
        {
            transform.position += new Vector3(0, velocidad*Time.deltaTime, 0);
        }
        else if (direccion == 2)
        {
            transform.position += new Vector3(0, -velocidad*Time.deltaTime, 0);
        }

        if (transform.position.y > limiteSuperior)
        {
            direccion = 2;
        }
        if (transform.position.y < limiteInferior)
        {
            direccion = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bala1" || collision.tag == "Bala2")
        {
            Destroy(collision.gameObject);
        }
    }
}
