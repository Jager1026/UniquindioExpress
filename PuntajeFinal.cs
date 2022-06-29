using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PuntajeFinal : MonoBehaviour
{
    [SerializeField] public float PuntosTotales;
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PuntosTotales = ControladorPuntosTotales.Instance.cantidadPuntosTotales;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = PuntosTotales.ToString();
    }
}
