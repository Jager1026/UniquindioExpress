using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pregunta3Gas : MonoBehaviour
{
    public bool Correct = false;
    public bool Wrong = false;
    public GameObject Correcto;
    public GameObject Incorrecto;
    public GameObject BotonIfFor;
    public GameObject BotonIfCase;
    public GameObject BotonForWhile;
    public GameObject BotonIfWhile;
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

    public void ClickIfFor()
    {
        Wrong = true;
    }
    public void ClickIfCase()
    {
        Correct = true;
    }
    public void ClickForWhile()
    {
        Wrong = true;
    }
    public void ClickIfWhile()
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
            BotonIfFor.gameObject.SetActive(false);
            BotonIfCase.gameObject.SetActive(false);
            BotonForWhile.gameObject.SetActive(false);
            BotonIfWhile.gameObject.SetActive(false);
            BotonNext.gameObject.SetActive(true);
        }
        if (Wrong == true)
        {
            Incorrecto.gameObject.SetActive(true);
            BotonIfFor.gameObject.SetActive(false);
            BotonIfCase.gameObject.SetActive(false);
            BotonForWhile.gameObject.SetActive(false);
            BotonIfWhile.gameObject.SetActive(false);
            BotonRetry.gameObject.SetActive(true);
        }
    }
}
