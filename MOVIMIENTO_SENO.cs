using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MOVIMIENTO_SENO : MonoBehaviour
{
    //Array   ID
    public string[] nombreJugadores;

    [SerializeField]
    Transform[] sierra;

    [SerializeField]
    Vector3[] posicionInicial;

    public float velocidad;
    public float extención;
    public float velocidadrotación;

    // Start is called before the first frame update
    void Start()
    {
        nombreJugadores = new string[4];

        posicionInicial = new Vector3[sierra.Length];
        posicionInicial[0] = sierra[0].position;
        posicionInicial[1] = sierra[1].position;
        posicionInicial[2] = sierra[2].position;

        for (int i = 0; i < sierra.Length; i++)
        {
            posicionInicial[i]= sierra[i].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extención, 0, 0);

        for (int i = 0; i < sierra.Length; i++)
        {
            sierra[i].position = posicionInicial[i] + senoPos;

            velocidadrotación = Random.Range(90, 180);

            sierra[i].Rotate(Vector3.forward * velocidadrotación);
            //metodo corto hacer rotar un objeto
        }
    }
}
