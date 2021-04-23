using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCamara : MonoBehaviour
{
    public Transform player;
    float alturaPlayer;

    public GameObject panelGameOver;
    public GameObject Jackie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alturaPlayer = player.transform.position.y;
        float alturaCamara = this.transform.position.y;
        float alturaCamaraActualizada = Mathf.Lerp(alturaCamara, alturaPlayer, Time.deltaTime * 15);
       

        if (alturaPlayer > alturaCamara)
        {
            this.transform.position = new Vector3(this.transform.position.x, alturaCamaraActualizada, this.transform.position.z);
        }
        else if(alturaPlayer<alturaCamaraActualizada - 6f)
        {
            Puntuaciones.puntuacion.VerificarPuntajeMaximo();
            panelGameOver.SetActive(true);
            Jackie.SetActive(false);
            //SceneManager.LoadScene("Mundo"); 
        }
        if (alturaPlayer>Puntuaciones.puntaje)
        {
            Puntuaciones.puntaje = (int)alturaPlayer;
        }


    }
}
