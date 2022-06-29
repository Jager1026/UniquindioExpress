using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntajeMundoLava : MonoBehaviour
{
    [SerializeField] public float PuntosActuales;
    public float PuntosFinales;
    public TextMeshProUGUI textMesh;
    private float verificador = 0;
    [SerializeField] private float cantidadPuntosTotales;
    // Start is called before the first frame update
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PuntosActuales = ControladorPuntosTotales.Instance.cantidadPuntosTotales;
        //textMesh.text = PuntosActuales.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {

        if (MetaMundoLava.instance.llego == true && verificador == 0)
        {
            verificador = verificador + 1;
            PuntosFinales = PuntosActuales + 200;
            textMesh.text = PuntosFinales.ToString();
            cantidadPuntosTotales=200;
            ControladorPuntosTotales.Instance.SumarPuntos(cantidadPuntosTotales);
        }
        else
        {
            textMesh.text = PuntosActuales.ToString();
        }
    }
}
