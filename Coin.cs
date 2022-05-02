using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;

    //public Vector3 moveDir;         // direction to move in
    public float moveSpeed=0.5f;         // speed to move at along moveDir
    public float Timetolive=5f;

    public AudioClip sound;

    [SerializeField]private float CantidadPuntos;
    [SerializeField]private Puntaje puntaje;

   // private float aliveTime = 8.0f; // time before object is destroyed
    void Start()
    {
        Destroy(gameObject, Timetolive);
        animator = GetComponent<Animator>();
    }

    public void move()
    {   
        //se mueve la moneda
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {   
        //se mueve la moneda
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {   
            //Se llama al metodo para que cada vez que se triggerea una moneda, se añadan puntos de acuerdo a CantidaPuntos
            //puntaje.SumarPuntos(CantidadPuntos);

            //se activa la transicion del aniamtor
            animator.SetBool("wasPicked",true);

            //se reproduce el sonido cuando la moneda es recogida
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);

            //se destruye el objeto 0.8 segundos despues (asi se observa bien la animacion)
            Destroy(gameObject,0.8f);
        }
    }
}
