using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{

    public GameObject panelMainMenu;
    public GameObject panelMundos;
    public GameObject panelPersonajes;
    public GameObject panelCreditos;
    public GameObject panelSalir;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPanelMainMenu()
    {
        panelMainMenu.SetActive(true);
        panelMundos.SetActive(false);
    }

    public void DesactivarPanelMainMenu()
    {
        panelMainMenu.SetActive(false);
    }

    public void ActivarPanelMundos()
    {
        panelMundos.SetActive(true);
        //panelMainMenu.SetActive(false);
    }

    public void DesactivarPanelMundos()
    {
        panelMainMenu.SetActive(true);
        panelMundos.SetActive(false);
    }

    public void ActivarPanelPersonajes()
    {
        panelPersonajes.SetActive(true);
       // panelMainMenu.SetActive(false);
    }

    public void DesactivarPanelPersonajes()
    {
        panelMainMenu.SetActive(true);
        panelPersonajes.SetActive(false); 
    }

    public void ActivarPanelCreditos()
    {
        panelCreditos.SetActive(true);
       // panelMainMenu.SetActive(false);
    }

    public void DesactivarPanelCreditos()
    {
        panelMainMenu.SetActive(true);
        panelCreditos.SetActive(false);
    }

    public void ActivarPanelSalir()
    {
        panelSalir.SetActive(true);
       // panelMainMenu.SetActive(false);
    }

    public void DesactivarPanelSalir()
    {
        panelMainMenu.SetActive(true);
        panelSalir.SetActive(false);
    }
}
