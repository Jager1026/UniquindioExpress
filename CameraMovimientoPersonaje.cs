using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimientoPersonaje : MonoBehaviour
{
    public GameObject PersonajeMLava;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = PersonajeMLava.transform.position.x;
        transform.position = position;
    }
}
