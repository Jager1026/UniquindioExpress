using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inducción : MonoBehaviour
{
    public int Estados = 1;
    public bool Atras = false;
    public bool Siguiente = false;
    public bool Repetir = false;
    public Animator FondoTuto;
    public GameObject RetryButton;
    public int numeroEscena = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        RetryButton.gameObject.SetActive(false);
    }
    public void ClickBack()
    {
        Atras = true;
    }
    public void ClickNext()
    {
        Siguiente = true;
    }
    public void ClickRetry()
    {
        Repetir = true;
    }
    // Update is called once per frame
    void Update()
    {
        //FondoTuto = GameObject.FindGameObjectWithTag("Tutorial");
        FondoTuto = GetComponent<Animator>();

        if (Siguiente)
        {
            Estados++;
            Siguiente = false;
        }
        if (Atras)
        {
            Estados--;
            Atras = false;
        }

        if (Estados == 2)
        {
            FondoTuto.SetInteger("Next", 2);
        }
        if (Estados == 3)
        {
            FondoTuto.SetInteger("Next", 3);
        }
        if (Estados == 4)
        {
            FondoTuto.SetInteger("Next", 4);
        }
        if (Estados == 5)
        {
            FondoTuto.SetInteger("Next", 5);
        }
        if (Estados == 6)
        {
            FondoTuto.SetInteger("Next", 6);
        }
        if (Estados == 7)
        {
            FondoTuto.SetInteger("Next", 7);
        }
        if (Estados == 8)
        {
            FondoTuto.SetInteger("Next", 8);
            RetryButton.gameObject.SetActive(true);
            SceneManager.LoadScene(numeroEscena);
            if (Repetir)
            {
                Estados = 2;
                Repetir = false;
            }
             
            //cambio de escena
        }
        else RetryButton.gameObject.SetActive(false);





    }


}
