using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemperaturaCajaCaliente : MonoBehaviour
{

    public int Estado = 10;
    public bool hot = false;
    public bool cold = false;
    public bool final = false;
    public Animator Batery;
    public int charge = 1;
    public GameObject Win;
    public GameObject Lose;
    public GameObject Retry;
    public GameObject Next;
    public GameObject BotonSubir;
    public GameObject BotonBajar;
    public GameObject BotonEnter;
    public GameObject TermometroCaliente;
    public GameObject CajaCaliente;
 

    // Start is called before the first frame update
    void Start()
    {
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
    }
    public void ClickEnter()
    {
        final = true;
    }
    public void ClickSubirTemp()
    {
        hot = true;
    }

    public void ClickBajarTemp()
    {
        cold = true;
    }
    public void ClickRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ClickNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    // Update is called once per frame
    void Update()
    {
        TermometroCaliente.gameObject.GetComponent<Animator>();
        CajaCaliente.gameObject.GetComponent<Animator>();

        if (hot)
        {
            Estado++;
            charge++;
            hot = false;
        }

        if (cold)
        {
            Estado--;
            charge++;
            cold = false;
        }
        if (charge == 1)
        {
            Batery.SetInteger("batery", 1);
        }
        if (charge == 2)
        {
            Batery.SetInteger("batery", 2);
        }
        if (charge == 3)
        {
            Batery.SetInteger("batery", 3);
        }
        if (charge == 4)
        {
            Batery.SetInteger("batery", 4);
        }
        if (charge == 5)
        {
            Batery.SetInteger("batery", 5);
        }
        if (charge == 6)
        {
            Batery.SetInteger("batery", 6);
        }
        if (charge == 7)
        {
            Batery.SetInteger("batery", 7);
        }
        if (charge == 8)
        {
            Batery.SetInteger("batery", 8);
        }
        if (charge == 9)
        {
            Batery.SetInteger("batery", 9);
        }
        if (charge == 10)
        {
            Batery.SetInteger("batery", 10);
        }

        if (Estado == 1)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 1);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 1);
        }
        if (Estado == 2)
        {   
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 2);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 2);
        }
        if (Estado == 3)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 3);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 3);
        }
        if (Estado == 4)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 4);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 4);
        }
        if (Estado == 5)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 5);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 5);
        }
        if (Estado == 6)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 6);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 6);
        }
        if (Estado == 7)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 7);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 7);
        }
        if (Estado == 8)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 8);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 8);
        }
        if (Estado == 9)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 9);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 9);
        }
        if (Estado == 10)
        {
            TermometroCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 10);
            CajaCaliente.gameObject.GetComponent<Animator>().SetInteger("State", 10);
        }
        if (final == true && Estado != 5)
        {
            Lose.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
        if (charge == 10)
        {
            Lose.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
        if (final == true && Estado == 5 && charge < 10)
        {
            Win.gameObject.SetActive(true);
            Next.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
    }
}
