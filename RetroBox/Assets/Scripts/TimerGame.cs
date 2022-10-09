using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour
{
    public float timer = 60f;

    public Text textTimer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        textTimer.text = timer.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        ReaunadrTiempo();
        CuentaAtras();
    }

    void CuentaAtras()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            textTimer.text = timer.ToString("0");
        }
        else if (timer <=0)
        {
            SceneManager.LoadScene(1);
        }
    }

	void ReaunadrTiempo()
	{
		if (Input.anyKeyDown)
		{
            Time.timeScale = 1;
		}
	}
}
