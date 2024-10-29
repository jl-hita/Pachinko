using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrGateS : MonoBehaviour
{
/*    [SerializeField]
    private TMP_Text _puntuacion;
*/
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
            Debug.Log("Sumar 10 puntos");
            scrJuego.puntuacion += 10;
            Debug.Log("Puntuación: " + scrJuego.puntuacion);
            Destroy(other.gameObject);
        }
    }
}
