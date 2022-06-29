using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Wind : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    [SerializeField] public float PuntosActuales;
    [SerializeField] public float PuntosAhora;
    private float verificador = 0;



    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PuntosActuales = ControladorPuntosTotales.Instance.cantidadPuntosTotales;
        puntos = PuntosActuales;
        PuntosAhora = 0;
    }
    private void Update()
    {
        textMesh.text = puntos.ToString("0");
        if (playerFallControllerWind.instance.meta == true  && verificador == 0)
        {
             ControladorPuntosTotales.Instance.SumarPuntos(PuntosAhora);
             verificador = verificador + 1;
        }
        
    }

    public void SumarPuntos(float PuntosEntrada)
    {
        puntos += PuntosEntrada;
        PuntosAhora = PuntosAhora + PuntosEntrada;
        
    }
}
