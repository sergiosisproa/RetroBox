using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PJ2 : MonoBehaviour
{
    public int hit = 0;
    public float velocidad = 1;
    public float cdMovimiento = 0.5f;
    public float cdDisparo = 0.5f;
    public float velocidadBala = 1;

    public GameObject prefabBala;

    public Text textHits;

    // Start is called before the first frame update
    void Start()
    {
        textHits.text = hit.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Disparo();
    }
    void Movimiento()
    {
        cdMovimiento -= Time.deltaTime;
        if (cdMovimiento < 0)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4)
            {
                transform.position += new Vector3(0, (velocidad), 0);
                cdMovimiento = 0.5f;
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4)
            {
                transform.position += new Vector3(0, -(velocidad), 0);
                cdMovimiento = 0.5f;
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 3)
            {
                transform.position += new Vector3 (-(velocidad),0 ,0);
                cdMovimiento = 0.5f;
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 6)
            {
                transform.position += new Vector3((velocidad),0, 0);
                cdMovimiento = 0.5f;
            }
        }
    }
    void Disparo()
    {
        cdDisparo -= Time.deltaTime;
        if (cdDisparo < 0)
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                GameObject clon;
                clon = Instantiate(prefabBala);
                clon.transform.position = transform.position;

                cdDisparo = 0.5f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bala1")
        {
            hit++;
            textHits.text = hit.ToString();
            Destroy(collision.gameObject);
        }
    }
}