using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarInstrucciones : MonoBehaviour
{
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Desactivar();
    }

    void Desactivar()
	{
		if (Input.anyKeyDown)
		{
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
