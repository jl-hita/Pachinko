using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrGateM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name.Contains("Ball"))
        {
            Debug.Log("Sumar 5 puntos");
            scrJuego.puntuacion += 5;
            Debug.Log("Puntuación: " + scrJuego.puntuacion);
            Destroy(other.gameObject);
        }
    }
}
