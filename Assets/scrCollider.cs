using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCollider : MonoBehaviour
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
            Destroy(other.gameObject);
        }
    }
}
