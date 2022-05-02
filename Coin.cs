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
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
        // move obstacle in certain direction over time
        //transform.position += moveDir * moveSpeed * Time.deltaTime;
        // rotate obstacle
        //transform.Rotate(Vector3.back * moveDir.x * (moveSpeed * 20) * Time.deltaTime);
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            //puntaje.SumarPuntos(CantidadPuntos);
            animator.SetBool("wasPicked",true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
            //tiemporeinicio += Time.time;
            //if (tiemporeinicio >= 1)
            //{
             //   animator.SetBool("ResetAnimation", true);
             //  Debug.Log("Animacion Reiniciada");
                // animator.SetBool("wasPicked", false);
            //    tiemporeinicio = 0;
           // }
            Destroy(gameObject,0.8f);
        }
    }
}
