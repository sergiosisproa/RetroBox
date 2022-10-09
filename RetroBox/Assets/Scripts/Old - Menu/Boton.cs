using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public string Escena;
    public Color[] colores;
    public Image BotonImage;
    public bool Seleccionado = false;

    // Start is called before the first frame update
    void Start()
    {
        BotonImage = GetComponent<Image>();
        BotonImage.color = colores[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Seleccionado)
        {
            BotonImage.color = colores[1];
        }
        else
        {
            BotonImage.color = colores[0];
        }

        if (Input.GetKeyDown(KeyCode.Space) && Seleccionado)
        {
            SceneManager.LoadScene(Escena, LoadSceneMode.Single);
        }
    }
}
