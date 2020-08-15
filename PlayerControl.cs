//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
 Este script se utilizara para generar el control del avatar jugador en 3D
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl3D : MonoBehaviour
{//Inicio del cuerpo de la clase

    //++++área para declarar variables++++

    //tipo de dato + nombre de variable
    Rigidbody fisicasRB;
    public Transform cabeza;
    //Cuando se declara una variable pública la podremos ver en el inspector//

    float Fuerzasalto_personaje;

    public int vida;

    //serializefield mantiene el acceso privado a variables//

    [SerializeField]
    float velocidad_personaje;

    float ejeZ;

    float rotacionX;
    float rotacionY;
   [SerializeField]
    float velocidadrotacionx;
    [SerializeField]
    float velocidadrotaciony;

    //++++++++


    // Start sirve para inicializar datos, componentes y variables//
    //cargar todos los GameObject, componentes, acciones, valores o eventos al juego//
    void Start()
    {
        fisicasRB = GetComponent<Rigidbody>();
        Fuerzasalto_personaje = 5.0F;
        velocidad_personaje = 1.0F;
        vida = 3;
        Cursor.visible=false;
    }

    // Update sirve para utilizar los datos componentes y variables//
    void Update()
    {
        #region Variables locales
        ejeZ = Input.GetAxis("vertical") * velocidad_personaje * Time.deltaTime;
        float ejeX = Input.GetAxis("horizontal") * velocidad_personaje * Time.deltaTime;
        rotacionX = Input.GetAxis("mouse X") * velocidadrotacionx;
        rotacionY = Input.mousePosition.x * velocidadrotacionx;
        #endregion

        //voy a usar una entrada (declaro un input) utilizo el operador punto para entrar en propiedades
        //elijo una y en este caso es una tecla presionada
        //le indico que tecla va a representar en el mundo físico o real esta entrada


        #region Movimiento

        if (Input.GetKeyDown(KeyCode.Space))

        { 
            
           //variabre a utilizar +
           //agregar una dureza +
           //dirección en que agrega esa fuerza la magnitud con que aplicarla +
           //agregar o traducir a un impulso

            fisicasRB.AddForce(Vector2.up * Fuerzasalto_personaje, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            fisicasRB.velocity = new Vector2(velocidad_personaje, fisicasRB.velocity.y);
        }
        #endregion

        #region Movimiento físicas

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    fisicasRB.velocity = new Vector2(-velocidad_personaje, fisicasRB.velocity.y);
        //}
        //if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space))
        //{
        //    Fuerzasalto_personaje = 0;
        //    gameObject.GetComponent<Collider2D>().enabled = false;
        //}

        //fisicasRB.velocity = new Vector3(fisicasRB.velocity.x, fisicasRB.velocity.y,ejeZ);
        #endregion

        #region Movimiento transforms

        transform.Translate(new Vector3(ejeX, 0, ejeZ));

        #endregion

        #region Rotacion

        rotacionY = Mathf.Clamp(rotacionY, -90, 90);

        //MOVIMIENTOS CABEZA
        transform.localEulerAngles= new Vector3(Input.mousePosition.y* -velocidadrotaciony, Input.mousePosition.x*velocidadrotacionx, 0);
        #endregion

        if (vida <= 0)
        {

        }
    }
}//Fin del cuerpo de la clase
