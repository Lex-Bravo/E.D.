using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparorayo : MonoBehaviour
{
    public float distanciarayo;
    public LayerMask CapaDaño;
    public Transform barril;
    public Image puntero;

    private Ray rayo;
    private RaycastHit hitinfo;
    private Ray rayointeraccion;
    private Vector2 centrocam;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        this.centrocam.x = Screen.width / 2;
        this.centrocam.y = Screen.height / 2;

    }

    // Update is called once per frame
    void Update()
    {
        rayo.origin = barril.position;
        rayo.direction = barril.forward;
        rayointeraccion = Camera.main.ScreenPointToRay(Camera.main.transform.position);

        Debug.DrawRay(rayointeraccion.origin, rayointeraccion.direction * distanciarayo, Color.green);

        if(Physics.Raycast(rayointeraccion,out hitinfo, distanciarayo, CapaDaño))
        {
            if(hitinfo.collider!= null)
            {
                if(hitinfo.collider.tag== "enemy")
                {
                    puntero.color = Color.green;
                }
            }
        }
        else
        {
            puntero.color = Color.white;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(rayo,out hitinfo, distanciarayo,CapaDaño))
            {
                if (hitinfo.collider != null)
                {
                    if (hitinfo.collider.name=="enemy")
                    {
                        Destroy(hitinfo.collider.gameObject);
                    }


                }
            }
        }
    }
}
