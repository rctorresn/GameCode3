using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaYGameOver : MonoBehaviour
{
    public GameObject panelPausa;
    public GameObject panelGameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("MainMenu1");
        Time.timeScale = 1;
    }

    public void ActivarPanelPausa()
    {
        panelPausa.SetActive(true);
        Time.timeScale = 0;
    }

    public void DesactivarPanelPausa()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReiniciarNivel1()
    {
        SceneManager.LoadScene("Mundo");
        Time.timeScale = 1;
    }
}
