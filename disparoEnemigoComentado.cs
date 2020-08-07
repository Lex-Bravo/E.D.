//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:

//Codigo para crear los disparos del enemigo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D proyectil;
    
    [SerializeField]
    Transform mano;
    
    [SerializeField]
    float fuerzaDisparo;
     
    // Start is called before the first frame update
    void Start()

        //Como se configurara el disparo del enemigo

    {
        InvokeRepeating("shoot", 0, 3f);
    }

    // Update is called once per frame
    
    void shoot()

    {
        var proyectilPos = Instantiate(proyectil as Rigidbody2D);

        proyectilPos.transform.position = mano.position;

        proyectilPos.AddForce(mano.right * -fuerzaDisparo);
    }
}
