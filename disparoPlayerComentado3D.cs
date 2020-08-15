//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
// Este código será utilizado para los disparos del jugador

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoPlayer : MonoBehaviour
{
    //aquí se colocan las variables que utilizaremos
    [SerializeField]
    Rigidbody[] Poyectil;

    [SerializeField]
    int tipomunicion;

    [SerializeField] 
    Transform mano;
 
    [SerializeField]
    float fueraDisparo;

    [SerializeField]
    KeyCode tecladisparo;
    
    [SerializeField]
    SpriteRenderer Enemigo;
    
    [SerializeField]
    Vector3[] PosicionInicial;

    public int contador = 0;
    public GameObject[] objEnemigo;
    public int proyectil = 3;
    //public SpriteRenderer Enemigo;

    // Start is called before the first frame update

    void Start()
    {
        //disparar();
    }

    // Update is called once per frame
    void Update()
    {
        //Si se presiona la tecla, habrá un disparo

        if (Input.GetKeyDown(tecladisparo))
        {

            var proyectilPos = Instantiate(Proyectil) as Rigidbody;
            proyectilPos.transform.position = mano.position;
            print("disparo proyectil" + contador);
            objEnemigo[contador].GetComponent<Rigidbody>();

            contador++;

          //  if(contador == objEnemigo.Length)
          //  {
          //       contador = 1;
          //  }

          //  //cant. proyectiles
          //if(proyectil == objEnemigo.Length)
          //  {
          //      proyectil = 3;
          //  }
          
        }
    }
}
