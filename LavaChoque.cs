using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaChoque : MonoBehaviour
{

    [SerializeField] private float tiempoEntreDa�o;
    private float tiempoSiguienteDa�o;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerLava"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDa�o(100);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }

        }
    }
    /*[SerializeField] private float tiempoEntreDa�o;
    private float tiempoSiguienteDa�o;

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
            tiempoSiguienteDa�o -= Time.deltaTime;
            /*if (tiempoSiguienteDa�o <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDa�o(5);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
}
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("PlayerLava"))
        {
            Debug.Log("Jugador Salio: ");
            tiempoEntreDa�o = 0;
        }
    }*/
}
