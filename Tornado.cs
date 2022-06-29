using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    public float moveSpeed = 0.5f;         // speed to move at along moveDir
    public float Timetolive = 15f;

    public AudioClip sonidoTornado;
    private AudioSource reproductor;

    // private float aliveTime = 8.0f; // time before object is destroyed
    void Start()
    {
        Destroy(gameObject, Timetolive);
        reproductor = GetComponent<AudioSource>();
    }

    public void move()
    {
        //se mueve el tornado
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        //se mueve la moneda
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealthControllerDesert>().takeDamage();
        }
    }
}
