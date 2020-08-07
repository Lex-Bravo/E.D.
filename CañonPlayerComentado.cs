//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
//Cod. para los cañones, la tecla de disparo y tipo de munición

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonPlayer : MonoBehaviour
{
    //las variables que se usarán para el funcionamiento del código

    [SerializeField] Rigidbody2D[] Proyectil;
    [SerializeField] int tipomunicion = 0;
    [SerializeField] Transform mano;
    [SerializeField] float fuerzaDisparo;
    [SerializeField] KeyCode teclaDisparo;

    // Update is called once per frame
    void Update()
    { 
        //If, input y tecla, los tipos de municion 

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            tipomunicion++;
        }
        if (tipomunicion == Proyectil.Length)
        {
            tipomunicion = Proyectil.Length - 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            tipomunicion--;
        }
        if(tipomunicion <= 0)
        {
            tipomunicion = 0;
        }

        if (Input.GetKeyDown(teclaDisparo))
        {
            var proyectilPos = Instantiate(Proyectil[tipomunicion]) as Rigidbody2D;
        }

        
    }
}
