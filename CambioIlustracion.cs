using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioIlustracion : MonoBehaviour
{
    public Image cambioDeIlustracion;
    public Sprite ilustracion1;
    public Sprite ilustracion2;
    public Sprite ilustracion3;
    public Sprite ilustracion4;


    // Start is called before the first frame update
    void Start()
    {
        cambioDeIlustracion = GetComponent < Image >();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioIlustracion1()
    {
        cambioDeIlustracion.sprite = ilustracion1;
    }
    public void CambioIlustracion2()
    {
        cambioDeIlustracion.sprite = ilustracion2;
    }
    public void CambioIlustracion3()
    {
        cambioDeIlustracion.sprite = ilustracion3;
    }
    public void CambioIlustracion4()
    {
        cambioDeIlustracion.sprite = ilustracion4;
    }
}
