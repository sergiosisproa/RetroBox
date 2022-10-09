using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    public Enemie[] prefabs;

    public int filas = 5;
    public int columnas = 6;
    public AnimationCurve velocidad;

    public int numeroMuertos { get; private set; }
    public int totalEnemigos => this.filas * this.columnas;
    public float porcentajeMuertos => (float)this.numeroMuertos / (float)this.totalEnemigos;

    private Vector3 direccion = Vector2.right;

    private void Awake()
    {
        for (int fila = 0; fila < this.filas; fila++)
        {
            float ancho = 2 * (this.columnas - 1);
            float alto = 1 * (this.filas - 3);
            Vector3 centrado = new Vector2(-ancho/2, -alto/2);
            Vector3 filaPosicion = new Vector3(centrado.x, centrado.y +(fila*1) ,0);

            for (int columna = 0; columna < columnas; columna++)
            {
                Enemie enemie = Instantiate(this.prefabs[fila], this.transform);
                enemie.muerte += EnemieMuerto;

                Vector3 posicion = filaPosicion;
                posicion.x += columna * 2;
                enemie.transform.position = posicion;
            }
        }
    }

    private void Update()
    {
        this.transform.position += direccion * this.velocidad.Evaluate(this.porcentajeMuertos) * Time.deltaTime;

        Vector3 bordeIzq = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 bordeDer = Camera.main.ViewportToWorldPoint(Vector3.right);

        foreach (Transform enemie in this.transform)
        {
            if (!enemie.gameObject.activeInHierarchy)
            {
                continue;
            }

            if (direccion == Vector3.right && enemie.position.x >= bordeDer.x)
            {
                CambioSentido();
            }
            else if (direccion == Vector3.left && enemie.position.x <= bordeIzq.x)
            {
                CambioSentido();
            }
        }
    }

    void CambioSentido()
    {
        direccion.x *= -1;
    }

    private void EnemieMuerto()
    {
        this.numeroMuertos++;

        if (this.numeroMuertos >= totalEnemigos)
        {
            SceneManager.LoadScene(1);
        }
    }
}
