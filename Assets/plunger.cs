using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class plunger : MonoBehaviour
{
    private static GameObject cilindro;
    private const double MaxDistance = 2;
    private const double MinDistance = 0;
    private const float DefaultfAccel = 0.015f;
    private static float PosicionCilindro;
    private static Vector3 PosicionInicial;
    
    public float fuerzaMuelle;
    public float compresion;
    public Rigidbody rb;

    void Start()
    {
        PosicionInicial = transform.position;
        rb = GetComponent<Rigidbody>();
        PosicionCilindro = rb.position.y;
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        //Por norma general hay una fuerza tipo muelle que empuja el émbolo hacia arriba, cual máquina de pinball
        if (PosicionCilindro < MaxDistance-0.10)
        {
            rb.AddForce(transform.up * fuerzaMuelle);
        }

        //Pero cuando se presiona la tecla "abajo" se aplica una fuerza contraria que comprime el muelle
        if (Input.GetKey(KeyCode.DownArrow) && PosicionCilindro >= MinDistance)
        {
            rb.AddForce(transform.up * -compresion);
        }

        //Para evitar que el plunger pase de la altura máxima
        if (PosicionCilindro >= MaxDistance && !Input.GetKey(KeyCode.DownArrow))
        {
            //rb.AddForce(transform.up * -fuerzaMuelle);
            transform.position = PosicionInicial;
            rb.velocity = new Vector3(0, 0, 0);
        }

        PosicionCilindro = rb.position.y;
        Debug.Log("Cilindro.y: " + PosicionCilindro);
    }
}
