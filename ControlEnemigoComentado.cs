//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
 //Código para respawn de enemigos, contador y cantidad
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigos : MonoBehaviour
{

    public static int contadorEnemigos;

    public GameObject objEnemigo;

    public Transform[] spawnPoint;

    public int infoCantidadEnemigos;


    // Start is called before the first frame update
    void Start()
    {
        contadorEnemigos = 0;
        spawnPoint = new Transform[transform.childCount];
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            spawnPoint[i] = transform.GetChild(i);
        }
        Invoke("spawn",6);
    }

    // Update is called once per frame
    void Update()
    {
        infoCantidadEnemigos = contadorEnemigos;

        infoCantidadEnemigos = contadorEnemigos;
        if (Input.GetKeyDown(KeyCode.E))
        {
          
           
        }
    }
    void spawn()
    {
        foreach (var p in spawnPoint)
        {
            GameObject EnemigoPos = Instantiate(objEnemigo) as GameObject;

            EnemigoPos.transform.position = p.position;
            if (contadorEnemigos >= 5)
            {
                Destroy(EnemigoPos);
            }
        }
    }
}
