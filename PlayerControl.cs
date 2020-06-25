//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 Este script se utilizara para generar el control del avatar jugador "Hatz"
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{//Inicio del cuerpo de la clase

    //++++área para declarar variables++++

    //tipo de dato + nombre de variable
    Rigidbody2D fisicasRB2D;

    //Cuando se declara una variable pública la podremos ver en el inspector//

    float Fuerzasalto_personaje;

    public int vida;

    //serializefield mantiene el acceso privado a variables//

    [SerializeField]
    float velocidad_personaje;

    public SpriteRenderer spritePlayer;

    //++++++++


    // Start sirve para inicializar datos, componentes y variables//
    //cargar todos los GameObject, componentes, acciones, valores o eventos al juego//
    void Start()
    {
        gameObject.name = "Hatz";
        fisicasRB2D = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        Fuerzasalto_personaje = 5.0F;
        velocidad_personaje = 3.0F;
        vida = 3;
    }

    // Update sirve para utilizar los datos componentes y variables//
    void Update()
    {
        //voy a usar una entrada (declaro un input) utilizo el operador punto para entrar en propiedades
        //elijo una y en este caso es una tecla presionada
        //le indico que tecla va a representar en el mundo físico o real esta entrada

        if (Input.GetKeyDown(KeyCode.W))

        { 
            
           //variabre a utilizar +
           //agregar una dureza +
           //dirección en que agrega esa fuerza la magnitud con que aplicarla +
           //agregar o traducir a un impulso

            fisicasRB2D.AddForce(Vector2.up * Fuerzasalto_personaje, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            fisicasRB2D.velocity = new Vector2(velocidad_personaje, fisicasRB2D.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            fisicasRB2D.velocity = new Vector2(-velocidad_personaje, fisicasRB2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space))
        {
            Fuerzasalto_personaje = 0;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }

        if (vida <= 0)
        {
           spritePlayer.enabled = false;
        }
    }
}//Fin del cuerpo de la clase
