using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDesierto : MonoBehaviour
{
    public Limpiar Estado;
    public Limpiar BotonLimpiar;

    public float tiempoD = 30.0f;
    public GameObject TimerDesert;
    public GameObject Cables;
    public GameObject Win;
    public GameObject Lose;
    public GameObject Retry;
    public GameObject Next;



    // Start is called before the first frame update
    void Start()
    {
        Estado = FindObjectOfType<Limpiar>();
        Debug.Log(Estado.State);

        Debug.Log(BotonLimpiar.CleanButton);

        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   

        if (Estado.State == 11)
        {
            Cables.gameObject.GetComponent<Animator>().enabled = false;
            BotonLimpiar.CleanButton.gameObject.SetActive(false);
            Win.gameObject.SetActive(true);
            Next.gameObject.SetActive(true);
        }

        TimerDesert = GameObject.FindGameObjectWithTag("Time");
        tiempoD -= Time.deltaTime;

        if (tiempoD < 0.0f)
        {
            TimerDesert.GetComponent<Animator>().SetBool("TimeOut", false);
            Lose.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            BotonLimpiar.CleanButton.gameObject.SetActive(false);
        }
    }
}