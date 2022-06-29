using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pregunta2Gas : MonoBehaviour
{
    public bool Correct = false;
    public bool Wrong = false;
    public GameObject Correcto;
    public GameObject Incorrecto;
    public GameObject BotonIf;
    public GameObject BotonFor;
    public GameObject BotonWhile;
    public GameObject BotonCase;
    public GameObject BotonNext;
    public GameObject BotonRetry;

    // Start is called before the first frame update
    void Start()
    {
        Correcto.gameObject.SetActive(false);
        Incorrecto.gameObject.SetActive(false);
        BotonNext.gameObject.SetActive(false);
        BotonRetry.gameObject.SetActive(false);
    }

    public void ClickIf()
    {
        Wrong = true;
    }
    public void ClickFor()
    {
        Wrong = true;
    }
    public void ClickWhile()
    {
        Correct = true;
    }
    public void ClickCase()
    {
        Wrong = true;
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
        if (Correct == true)
        {
            Correcto.gameObject.SetActive(true);
            BotonIf.gameObject.SetActive(false);
            BotonFor.gameObject.SetActive(false);
            BotonWhile.gameObject.SetActive(false);
            BotonCase.gameObject.SetActive(false);
            BotonNext.gameObject.SetActive(true);
        }
        if (Wrong == true)
        {
            Incorrecto.gameObject.SetActive(true);
            BotonIf.gameObject.SetActive(false);
            BotonFor.gameObject.SetActive(false);
            BotonWhile.gameObject.SetActive(false);
            BotonCase.gameObject.SetActive(false);
            BotonRetry.gameObject.SetActive(true);
        }
    }
}
