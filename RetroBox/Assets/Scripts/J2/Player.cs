using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public BalaPlayer balaPrefab;

    public float velocidad = 5f;
    public float cd = 0.25f;
    bool BalaActiva;

    private void Update()
    {
        Movimiento();
        Disparo();
    }

    void Movimiento()
    {
        cd -= Time.deltaTime;
        if (cd < 0)
        {
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < 6)
            {
                transform.position += new Vector3((velocidad), 0, 0);
                cd = 0.25f;
            }
            else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -6)
            {
                transform.position += new Vector3(-(velocidad), 0, 0);
                cd = 0.25f;
            }
        }
    }

    void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.Insert))
        {
            if (!BalaActiva)
            {
                BalaPlayer bala = Instantiate(this.balaPrefab, this.transform.position, Quaternion.identity);
                bala.destruido += BalaDestruida;
                BalaActiva = true;
            }
        }
    }

    void BalaDestruida()
    {
        BalaActiva = false;
    }
}