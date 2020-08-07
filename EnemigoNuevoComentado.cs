//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
  //Este código funcionará para el contador de enemigos en el nivel

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoNuevo : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        ControlEnemigos.contadorEnemigos++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
