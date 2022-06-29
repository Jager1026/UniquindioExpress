using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlFlecha : MonoBehaviour
{

    bool isCicle;
    int estados = 0;
    public GameObject Arrow;
    public GameObject Tiempo;
    public GameObject Turbina;
    public GameObject Humo;
    public GameObject Win;
    public GameObject Lose;
    public GameObject Bottom;
    public GameObject Retry;
    public GameObject Next;

    // Start is called before the first frame update
    void Start()
    {
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
    }
    public void ClickCicle()
    {
        isCicle = true;
    }
    public void ClickRetry()
    {
        //Acci�n para la reiniciar la escena checkpoint
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ClickNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        Arrow = GameObject.FindGameObjectWithTag("Arrow");
        Tiempo = GameObject.FindGameObjectWithTag("Time");
        Turbina = GameObject.FindGameObjectWithTag("Turbina");
        Humo = GameObject.FindGameObjectWithTag("Humo");
        
        if (isCicle)
        {
            Arrow.transform.rotation = Arrow.transform.rotation * Quaternion.Euler(0,0, -5f);
        }
        if (Arrow.transform.rotation == Quaternion.Euler(0, 0, 20f))
        {
            Turbina.GetComponent<Animator>().SetBool("Normal", true);
            estados = 1;
        }
        if (Arrow.transform.rotation == Quaternion.Euler(0, 0, -25f))
        {
            Turbina.GetComponent<Animator>().SetBool("Caliente", true);
            estados = 2;
        }
        if (Tiempo.GetComponent<Animator>().GetBool("TimeOut") == false)
        {
            Bottom.gameObject.SetActive(false);
            if (estados == 0)
            {
                Humo.GetComponent<Animator>().SetBool("TimeOut", true);
                Humo.GetComponent<Animator>().SetBool("Frio", true);
                Lose.gameObject.SetActive(true);
                Retry.gameObject.SetActive(true);
            }
            else if (estados == 1)
            {
                Win.gameObject.SetActive(true);
                Next.gameObject.SetActive(true);
                
            }
            else if (estados == 2)
            {
                Humo.GetComponent<Animator>().SetBool("TimeOut", true);
                Humo.GetComponent<Animator>().SetBool("Caliente", true);
                Lose.gameObject.SetActive(true);
                Retry.gameObject.SetActive(true);
            }
           
        }
        isCicle = false;

    }
}