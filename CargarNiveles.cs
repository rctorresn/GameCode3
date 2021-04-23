using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNiveles : MonoBehaviour
{
    public GameObject panelCargado;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarNivel1()
    {
        StartCoroutine(EsperaPantallaCargado());
        
    }

    IEnumerator EsperaPantallaCargado()
    {
        panelCargado.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Mundo");
        Time.timeScale = 1;

    }
}
