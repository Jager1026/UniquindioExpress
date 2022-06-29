using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introduccion_desierto : MonoBehaviour
{
    public int Estados = 1;
    public bool Atras = false;
    public bool Siguiente = false;
    public Animator FondoWhile;
    public GameObject BackButton;

    // Start is called before the first frame update
    void Start()
    {
        BackButton.gameObject.SetActive(false);
    }
    public void ClickBack()
    {
        Atras = true;
    }
    public void ClickNext()
    {
        Siguiente = true;
    }
    // Update is called once per frame
    void Update()
    {
        //FondoTuto = GameObject.FindGameObjectWithTag("Tutorial");
        FondoWhile = GetComponent<Animator>();

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
        if (Estados == 1)
        {
            FondoWhile.SetInteger("Siguiente", 1);
        }
        if (Estados == 2)
        {
            FondoWhile.SetInteger("Siguiente", 2);
        }
        if (Estados == 3)
        {
            FondoWhile.SetInteger("Siguiente", 3);
        }
        if (Estados == 4)
        {
            FondoWhile.SetInteger("Siguiente", 4);
        }
        if (Estados == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Estados >= 2)
        {
            BackButton.gameObject.SetActive(true);
        }
        if (Estados <= 1)
        {
            BackButton.gameObject.SetActive(false);
        }

    }
}
