using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NombrePersonaje : MonoBehaviour
{
    public static NombrePersonaje Instance;
    [SerializeField] public string nombreTotal;
    
    private void Awake()
    {
        if (NombrePersonaje.Instance == null)
        
        {
            NombrePersonaje.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GuardarNombre(string nombre)
    {
        nombreTotal = nombre;
        //ControladorPuntosTotales.Instance.SumarPuntos(cantidadPuntosTotales);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
