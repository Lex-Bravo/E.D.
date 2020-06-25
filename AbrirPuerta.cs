using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
Este script funcionara para puerta o checkpoint
*/


public class AbrirPuerta : MonoBehaviour
{
    [SerializeField]
    PlayerControl player_vida;

    // Start is called before the first frame update
    void Start()
        //Se manejará la vida del personaje y se buscará en los scripts
    {
        player_vida = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player_vida.vida--;

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player_vida.vida--;

        }
    }


}
