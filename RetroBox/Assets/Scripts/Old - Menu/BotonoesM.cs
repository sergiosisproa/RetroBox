using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonoesM : MonoBehaviour
{
    public Boton[] botones;
    public int Posicion = 0;

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            botones[Posicion].Seleccionado = false;
            Posicion++;

            if (Posicion < 0)
            {
                Posicion = botones.Length - 1;
                botones[Posicion].Seleccionado = true;
                return;
            }

            if (Posicion > botones.Length - 1)
            {
                Posicion = 0;
                botones[Posicion].Seleccionado = true;
                return;
            }
        }

        botones[Posicion].Seleccionado = true;
    }
}
