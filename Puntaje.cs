using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public float puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }



    public void agregarPuntos()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }
    // private void Update()
    //{
    //   puntos += Time.deltaTime;
    //    textMesh.text = puntos.ToString("0");
    //  }
    public void SumarPuntos(float PuntosEntrada)
    {
        puntos += PuntosEntrada;
    }
}
