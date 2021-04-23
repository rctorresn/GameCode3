using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlataformas : MonoBehaviour
{
    public Transform plataformaNormal;
    public Transform plataformaMovimiento;
    public Transform plataformaMegaSalto;
    public Transform plataformaDesaparece;

    int numeroDePlataforma;// da un identificador de cada plataforma

    public Transform player;
    float alturaPlayer;

    float verificadorPlataforma;
    float generarPlataforma;

    // Start is called before the first frame update
    void Start()
    {
        generadorPlataformas(-2);
    }

    // Update is called once per frame
    void Update()
    {
        alturaPlayer = player.transform.position.y;

        if(alturaPlayer > verificadorPlataforma)
        {
            plataformaManejador();
        }
    }

    void plataformaManejador()
    {
        verificadorPlataforma = player.transform.position.y + 15;
        generadorPlataformas(verificadorPlataforma + 15);

    }

    void generadorPlataformas(float valorDeFloat)
    {
        float y = generarPlataforma;
        while (y <= valorDeFloat)
        {
            float x = Random.Range(-9, 9);
            numeroDePlataforma = Random.Range(1, 5);

            Vector2 posicionEnXyY = new Vector2(x,y);

            if (numeroDePlataforma == 1)
            {
                Instantiate(plataformaNormal, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 2)
            {
                Instantiate(plataformaMovimiento, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 3)
            {
                Instantiate(plataformaMegaSalto, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 4)
            {
                Instantiate(plataformaDesaparece, posicionEnXyY, Quaternion.identity);
            }
            y += Random.Range(0.2f, 4.5f);
        }
        generarPlataforma = valorDeFloat;

        
    }

}
