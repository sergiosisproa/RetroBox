using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ladrillos : MonoBehaviour
{
    int ladrillos = 61;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("CambiarColor", 1f, 1f);
    }


    void Update()
    {
        Fin();
    }

    void Fin()
    {
        if (ladrillos == 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    void CambiarColor()
    {
        spriteRenderer.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        ladrillos--;
    }
}
