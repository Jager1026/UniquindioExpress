using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroduccionAire : MonoBehaviour
{
    public int Estados = 1;
    public bool Atras = false;
    public bool Siguiente = false;
    public Animator FondoFor;
    public GameObject BackButton;
    public GameObject NextButton;

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
        FondoFor = GetComponent<Animator>();

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
            FondoFor.SetInteger("NextAire", 1);
        }
        if (Estados == 2)
        {
            FondoFor.SetInteger("NextAire", 2);
        }
        if (Estados == 3)
        {
            FondoFor.SetInteger("NextAire", 3);
        }
        if (Estados == 4)
        {
            FondoFor.SetInteger("NextAire", 4);
        }
         if (Estados > 4)
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
