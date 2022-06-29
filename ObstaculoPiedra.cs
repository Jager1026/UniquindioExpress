using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoPiedra : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;
    public AudioClip sound;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("PlayerLava"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<VariadorDeVidaJugador>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
                Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            }
            
        }
    }
}
