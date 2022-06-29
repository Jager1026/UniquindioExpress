using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntosTotales : MonoBehaviour
{
    public static ControladorPuntosTotales Instance;
    [SerializeField] public float cantidadPuntosTotales;
    
    private void Awake()
    {
        if (ControladorPuntosTotales.Instance == null)
        
        {
            ControladorPuntosTotales.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(float puntos)
    {
        cantidadPuntosTotales += puntos;
        //ControladorPuntosTotales.Instance.SumarPuntos(cantidadPuntosTotales);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
