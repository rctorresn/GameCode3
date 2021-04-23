﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject player;
    public GameObject panelGameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Puntuaciones.puntuacion.VerificarPuntajeMaximo();
            panelGameOver.SetActive(true);
            player.SetActive(false);
        }
    }
}
