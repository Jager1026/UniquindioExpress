using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaMundoLava : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;
    public bool llego = false;
    public static MetaMundoLava instance;
    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerLava"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                llego = true; 
                Debug.Log("Jugador Gano");
                tiempoSiguienteDaño = tiempoEntreDaño;
            }

        }
    }
}
