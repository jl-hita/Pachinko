using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrJuego : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _puntuacion;
    [SerializeField]
    private TMP_Text _bolasLeft;

    public GameObject bolaPrefab;
    public static int puntuacion = 0;
    public static int bolas = 99;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bolaPrefab, new Vector3(4f, 3f, -0.383f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        _puntuacion.text = puntuacion.ToString();
        _bolasLeft.text = bolas.ToString();
    }
}
