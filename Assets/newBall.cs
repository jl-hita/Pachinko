using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBall : MonoBehaviour
{
    public GameObject bolaPrefab;
    void Start()
    {
    }

    void Update()
    {    
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(bolaPrefab, new Vector3(4f, 3f, -0.383f), Quaternion.identity);
        scrJuego.bolas--;
    }
}
