using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 200f;
    public new Rigidbody2D rigidbody { get; private set; }

    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        FuerzaInicio();
        InvokeRepeating("CambiarColor", 2f, 2f);
    }

    void CambiarColor()
    {
        spriteRenderer.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    public void ReiniciarPosicion()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;
    }

    public void FuerzaInicio()
    {
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * speed);
    }

}
