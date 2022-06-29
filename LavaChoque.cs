using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaChoque : MonoBehaviour
{

    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerLava"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDaño(100);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }

        }
    }
    /*[SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("PlayerLava"))
        {
            Debug.Log("Jugador Cayo");
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("PlayerLava"))
        {
            Debug.Log("Jugador en lava");
            tiempoSiguienteDaño -= Time.deltaTime;
            /*if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
}
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("PlayerLava"))
        {
            Debug.Log("Jugador Salio: ");
            tiempoEntreDaño = 0;
        }
    }*/
}
