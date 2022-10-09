using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    public Sprite[] animationSprites;

    public float animationTime = 1f;
    public System.Action muerte;

    private SpriteRenderer spritRenderer;

    private int animationFrame;

    private void Awake()
    {
        spritRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), this.animationTime, this.animationTime);
    }

    private void AnimateSprite()
    {
        animationFrame++;

        if (animationFrame >= this.animationSprites.Length)
        {
            animationFrame = 0;
        }

        spritRenderer.sprite = this.animationSprites[animationFrame];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bala"))
        {
            this.muerte.Invoke();
            this.gameObject.SetActive(false);
        }
    }
}
