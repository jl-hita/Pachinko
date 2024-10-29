using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrGateSmall : MonoBehaviour
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
// Funcionan los dos modos:
//        if (other.transform.name.Contains("Ball"))
        if (other.tag == "Ball")
        {
            Debug.Log("Añadir 1 bola extra");
            scrJuego.bolas ++;
            Debug.Log("Bolas: " + scrJuego.bolas);
            Destroy(other.gameObject);
        }
    }
}
