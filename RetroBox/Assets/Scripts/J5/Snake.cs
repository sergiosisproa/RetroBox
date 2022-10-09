using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    private Vector2 direccion = Vector2.right;

    private List<Transform> segmentos;
    public Transform segmentoPrefab;

    public float velocidad = 1f;

    private void Start()
    {
        segmentos = new List<Transform>();
        segmentos.Add(this.transform);
    }

    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                direccion = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                direccion = Vector2.down;
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direccion = Vector2.left;
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                direccion = Vector2.right;
            }    }

    private void FixedUpdate()
    {
        for (int i = segmentos.Count-1; i > 0; i--)
        {
            segmentos[i].position = segmentos[i - 1].position;
        }
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x) + direccion.x , Mathf.Round(this.transform.position.y) + direccion.y, 0.0f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Muro" || other.tag == "Snake")
        {
            SceneManager.LoadScene(1);
        }

        if (other.tag == "Manzana")
        {
            Crecer();
        }
    }

    void Crecer()
    {
        Transform segmento = Instantiate(this.segmentoPrefab);
        segmento.position = segmentos[segmentos.Count - 1].position;

        segmentos.Add(segmento);
    }

   
}
