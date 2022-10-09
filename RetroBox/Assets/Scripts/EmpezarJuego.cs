using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarJuego : MonoBehaviour
{
    float temporizador = 3f;

    
    void Update()
    {
        temporizador -= Time.deltaTime;

        if (temporizador < 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
