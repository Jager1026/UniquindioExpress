using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform personaje;
    private float tamañoCamara;
    private float alturaPantalla;
    
    // Start is called before the first frame update
    void Start()
    {
        tamañoCamara = Camera.main.orthographicSize;
        alturaPantalla = tamañoCamara*4;

    }

     //Update is called once per frame
    void Update()
    {
        CalcularPosicionCamera();
    }

    void CalcularPosicionCamera()
    {
       int pantallaPersonaje = (int)(personaje.position.y / alturaPantalla);
        float alturaCamara = (pantallaPersonaje * alturaPantalla) + tamañoCamara;

        transform.position = new Vector3(transform.position.x, alturaCamara, transform.position.z);
    }
}
