using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = puntos.ToString("0");
    }

    public void SumarPuntos(float PuntosEntrada)
    {
        puntos += PuntosEntrada;
    }
}
