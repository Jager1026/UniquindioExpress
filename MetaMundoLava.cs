using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaMundoLava : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDa�o;
    private float tiempoSiguienteDa�o;
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
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o <= 0)
            {
                llego = true; 
                Debug.Log("Jugador Gano");
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }

        }
    }
}
