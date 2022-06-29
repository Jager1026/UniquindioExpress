using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariadorDeVidaJugador : MonoBehaviour
{
    [SerializeField] public float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraDeVidaLava barraDeVidaLava;
    public static VariadorDeVidaJugador instance;
    private void Awake()
    {
        instance = this;
    }
    //Start is called before the first frame update
    private void Start()
    {
        vida = maximoVida;
        barraDeVidaLava.InicializarBarraVidaLava(vida);
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        barraDeVidaLava.CambiarVidaActual(vida);
        /*if (vida <= 0)
        {
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }*/
    }
}
