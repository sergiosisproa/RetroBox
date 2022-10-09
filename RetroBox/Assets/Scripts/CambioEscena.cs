using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{

    public void Update(int indiceNivel)
    {
        Input.ReferenceEquals(KeyCode.U, KeyCode.Space);
        Input.ReferenceEquals(KeyCode.Space, KeyCode.Insert);

        if (Input.GetKey(KeyCode.U) || Input.GetKey(KeyCode.Insert) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(indiceNivel);
        }

    }
}
