using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour
{
    public BoxCollider2D area;

    private SpriteRenderer spritRenderer;

    private void Start()
    {
        RandoPosicion();

        spritRenderer = GetComponent<SpriteRenderer>();
    }

    void RandoPosicion()
    {
        Bounds bounds = this.area.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    void RandoColor()
	{
        spritRenderer.color = new Color (Random.Range(0,1f), Random.Range(0, 1f), Random.Range(0, 1f));
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snake")
        {
            RandoPosicion();
            //RandoColor();
        }
    }
}
