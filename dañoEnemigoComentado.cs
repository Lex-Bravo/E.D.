//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
//Código daño por cólisiones con enmigos 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se registra la colision
public class dañoEnemigo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
