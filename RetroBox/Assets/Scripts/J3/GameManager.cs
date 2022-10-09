using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Bola bola;

    public JugadorIzq JugadorIzq;
    public int izqPuntos { get; private set; }
    public Text izqPunto;

    public JugadorDer JugadorDer;
    public int derPuntos { get; private set; }
    public Text derPunto;

    

    public void JuegoNuevo()
    {
        bola.ReiniciarPosicion();
        bola.FuerzaInicio();
    }

    public void PuntosIzq()
    {
        IzqPuntos(izqPuntos + 1);
        JuegoNuevo();
    }

    public void PuntosDer()
    {
        DerPuntos(derPuntos + 1);
        JuegoNuevo();
    }

    private void IzqPuntos(int score)
    {
        izqPuntos = score;
        izqPunto.text = score.ToString();
    }

    private void DerPuntos(int score)
    {
        derPuntos = score;
        derPunto.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MuroIzq")
        {
            PuntosDer();
        }
        if (collision.tag == "MuroDer")
        {
            PuntosIzq();
        }
    }
}
