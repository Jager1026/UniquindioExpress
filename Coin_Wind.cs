using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Wind : MonoBehaviour
{
    public static Coin_Wind instance;
    private Animator animator;
    public AudioClip sound;
    public bool Picked;

    [SerializeField] private Score_Wind puntaje;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !Picked)
        {
            //Se llama al metodo para que cada vez que se triggerea una moneda, se añadan puntos de acuerdo a CantidaPuntos
            //puntaje.SumarPuntos(CantidadPuntos);

            //se activa la transicion del aniamtor
            animator.SetBool("wasPicked", true);

            //se suman puntos
            puntaje.SumarPuntos(10);


            //se reproduce el sonido cuando la moneda es recogida
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);

            //se destruye el objeto 0.8 segundos despues (asi se observa bien la animacion)
            Destroy(gameObject, 0.79f);
            Picked = true;

        }
    }
}
