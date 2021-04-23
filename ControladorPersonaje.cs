using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public Transform detectorSuelo; //Captura el objeto detector con el suelo
    public bool tocandoSuelo; //Variable condicion de tocar el suelo o no
    public float fuerzaSalto; //almacena la fuerza del salto
    public float rangoSuelo; //Genera el rango permitido para detectar el suelo
    public LayerMask suelo; //identificador elementos del suelo

    public float velocidadMovimiento;//determina la velocidad en el eje x del player
    float arribaOAbajo;

    public float fuerzaMegaSalto;//almacena fuerza megasalto

    bool moverDerecha;
    bool moverIzquierda;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moverDerecha)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * velocidadMovimiento);
        }

        if (moverIzquierda)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * velocidadMovimiento);
        }

        arribaOAbajo = GetComponent<Rigidbody2D>().velocity.y;

        float controlHorizontal = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(controlHorizontal * velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);
    }

    private void FixedUpdate()
        {
        tocandoSuelo = Physics2D.OverlapCircle(detectorSuelo.position, rangoSuelo, suelo);

        if (tocandoSuelo && arribaOAbajo<=0)
        {
            GetComponent<Rigidbody2D>().velocity =  new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce (new Vector2(0, fuerzaSalto));
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "MegaSalto" && arribaOAbajo <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaMegaSalto));
        }
    }

    public void MoverPlayerDerecha()
    {
        moverDerecha = true;
    }

    public void MoverPlayerIzquierda()
    {
        moverIzquierda = true;
    }

    public void DetenerMovimiento()
    {
        moverDerecha = false;
        moverIzquierda = false;
    }
} 
