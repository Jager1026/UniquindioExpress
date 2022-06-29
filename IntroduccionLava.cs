using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroduccionLava : MonoBehaviour
{
    public int Estados = 1;
    public bool Atras = false;
    public bool Siguiente = false;
    public Animator FondoCase;
    public GameObject BackButton;
    public GameObject NextButton;
    public GameObject AButton;
    public GameObject BButton;

    // Start is called before the first frame update
    void Start()
    {
        BackButton.gameObject.SetActive(false);
        AButton.gameObject.SetActive(false);
        BButton.gameObject.SetActive(false);
    }

    public void ClickBack()
    {
        Atras = true;
    }
    public void ClickNext()
    {
        Siguiente = true;
    }

    public void ClicA()
    {
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void ClicB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    // Update is called once per frame
    void Update()
    {
        //FondoTuto = GameObject.FindGameObjectWithTag("Tutorial");
        FondoCase = GetComponent<Animator>();

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
            FondoCase.SetInteger("nextlava", 1);
        }
        if (Estados == 2)
        {
            FondoCase.SetInteger("nextlava", 2);
        }
        if (Estados == 3)
        {
            FondoCase.SetInteger("nextlava", 3);
        }
        if (Estados == 4)
        {
            FondoCase.SetInteger("nextlava", 4);
            AButton.gameObject.SetActive(true);
            BButton.gameObject.SetActive(true);
            NextButton.gameObject.SetActive(false);
           
        }
        if (Estados >= 2)
        {
            BackButton.gameObject.SetActive(true);
        }
        if (Estados <= 1)
        {
            BackButton.gameObject.SetActive(false);
        }
        if (Estados !=4)
        {
            AButton.gameObject.SetActive(false);
            BButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(true);
        }
    }
}
