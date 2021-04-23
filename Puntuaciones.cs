using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuaciones : MonoBehaviour
{
    public static Puntuaciones puntuacion;
    public static int puntaje;

    int puntajeMax;
    Text textoPuntaje;
    Text textoPuntajeMax;

    // Start is called before the first frame update
    void Start()
    {
        puntuacion = this;
        puntaje = 0;
        puntajeMax = PlayerPrefs.GetInt("puntajeMaximo", 0);

        textoPuntaje = GameObject.Find("Puntaje").GetComponent<Text>();
        textoPuntajeMax = GameObject.Find("Puntaje_Max").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = "Puntaje" + puntaje;
        textoPuntajeMax.text = "Puntaje_Max" + puntajeMax;
    }

    public void VerificarPuntajeMaximo()
    {
        if (puntaje>puntajeMax)
        {
            PlayerPrefs.SetInt("puntajeMaximo", puntaje);
        }

    }
}
