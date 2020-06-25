using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
Este script funcionara ppara simular la destrucción de un objeto al ser colisionado por otro
*/

public class BOOM : MonoBehaviour
{
    //cronometro para el tiempo de detonación dinamita//
    //SpriteRenderer ayuda a llamar de otro código

    [SerializeField]
    float cronometro = 0.0f;

    [SerializeField]
    SpriteRenderer spritePared;

    [SerializeField]
    PlayerControl player_vida;

    // Start sirve para inicializar datos, componentes y variables//
    private void Start()
    {
        spritePared =GameObject.Find("pared_1").GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision) //evento o mecánica núcleo//
    {
        //******Bloque 1 

        //registra la explosión al momento de colisión con pared//

        if (collision.gameObject.tag == "pared")
        {
            spritePared.color = Color.red;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        //*********Bloque 2
        //registra colision y evento a activarse con un objeto player
        //reducirá la vida del player

        if (collision.gameObject.tag == "Player")
        {
            player_vida.vida--;
         
            Debug.Log("al infinito y más allá");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        //*********bloque aislado+++++++++++++++
        //Localización de un objeto y los almaceno en collision.gameobject

        if (collision.gameObject.tag == "pared")
        {

            cronometro = cronometro + 0.5f * Time.deltaTime;

            //*******bloque aislado 2****
            
            if (cronometro >= 5.0f) 
                //cronometro servirá para que la llegar el contador a 5 exista una colisión y un destroy
            {
                cronometro = 5.0f;
                if (cronometro == 5.0f)
                {
                    Destroy(collision.gameObject);
                    Destroy(this.gameObject); 
                }
                
            }


        }  
        //***********++++++++++++++++++++++++++
    }
}
