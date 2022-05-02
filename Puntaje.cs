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
        //se accede al componente de la interfaz
        textMesh = GetComponent<TextMeshProUGUI>();
    }



    public void agregarPuntos()
    {
        //se añaden puntos cada segundo
        puntos += Time.deltaTime;

        //se escriben los puntos en la interfaz
        textMesh.text = puntos.ToString("0");
    }
    // private void Update()
    //{
    //   puntos += Time.deltaTime;
    //    textMesh.text = puntos.ToString("0");
    //  }

    //metodo para sumar puntos
    public void SumarPuntos(float PuntosEntrada)
    {
        puntos += PuntosEntrada;
    }
}
