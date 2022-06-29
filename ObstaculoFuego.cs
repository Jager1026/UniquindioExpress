using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoFuego : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDa�o;
    private float tiempoSiguienteDa�o;
    public AudioClip sound;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerLava"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDa�o(10);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
                Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            }

        }
    }
}
