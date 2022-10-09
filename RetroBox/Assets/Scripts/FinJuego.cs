using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJuego : MonoBehaviour
{
    public float tSalida = 10f;

    // Update is called once per frame
    void Update()
    {
        tSalida -= Time.deltaTime;

        if (tSalida < 0)
        {
            Application.Quit();
        }
    }
}
