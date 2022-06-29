using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArreglarAntena : MonoBehaviour
{
    //public int Estado = 1;
    public int pos;
    public bool up = false;
    public bool down = false;
    public bool final = false;
    public Animator Pinones;
    public int pinon = 1;
    public GameObject Win;
    public GameObject Lose;
    public GameObject Retry;
    public GameObject Next;
    public GameObject BotonSubir;
    public GameObject BotonBajar;
    public GameObject BotonEnter;
    public GameObject Antena;
    public GameObject Cursor;

    // Start is called before the first frame update
    void Start()
    {
        Antena = GameObject.FindGameObjectWithTag("Antena");
        Antena.transform.rotation = Quaternion.Euler(0, 0, -20f);
        Cursor = GameObject.FindGameObjectWithTag("Cursor");
        Cursor.transform.position = new Vector3(5f, -3f, 0f);
        pos = Random.Range(-6, 7);
        Antena.transform.rotation = Antena.transform.rotation * Quaternion.Euler(0, 0, -pos*10f);
        //Cursor.transform.position = Cursor.transform.position + new Vector3(-pos, 0f, 0f);
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        
        if (Antena.transform.rotation == Quaternion.Euler(0, 0,40f))
        {
            Cursor.transform.position = new Vector3(3.80f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, 30f))
        {
            Cursor.transform.position = new Vector3(4.0f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, 20f))
        {
            Cursor.transform.position = new Vector3(4.20f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, 10f))
        {
            Cursor.transform.position = new Vector3(4.40f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, 0f))
        {
            Cursor.transform.position = new Vector3(4.60f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -10f))
        {
            Cursor.transform.position = new Vector3(4.80f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -20f))
        {
            Cursor.transform.position = new Vector3(5f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -30f))
        {
            Cursor.transform.position = new Vector3(5.2f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -40f))
        {
            Cursor.transform.position = new Vector3(5.4f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -50f))
        {
            Cursor.transform.position = new Vector3(5.6f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -60f))
        {
            Cursor.transform.position = new Vector3(5.8f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -70f))
        {
            Cursor.transform.position = new Vector3(6f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -80f))
        {
            Cursor.transform.position = new Vector3(6.2f, -2.97f, 0f);
        }
        if (Antena.transform.rotation == Quaternion.Euler(0, 0, -90f))
        {
            Cursor.transform.position = new Vector3(6.4f, -2.97f, 0f);
        }
    }

    public void ClickEnter()
    {
        final = true;
    }
    public void ClickSubir()
    {
        up = true;
    }

    public void ClickBajar()
    {
        down = true;
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
        Cursor = GameObject.FindGameObjectWithTag("Cursor");
        Antena = GameObject.FindGameObjectWithTag("Antena");

        if (up)
        {
            Antena.transform.rotation = Antena.transform.rotation * Quaternion.Euler(0, 0, 5f);
            Cursor.transform.position = Cursor.transform.position + new Vector3(-0.1f, 0f, 0f);
            pinon++;
            up = false;
        }

        if (down)
        {
            Antena.transform.rotation = Antena.transform.rotation * Quaternion.Euler(0, 0, -5f);
            Cursor.transform.position = Cursor.transform.position + new Vector3(0.1f, 0f, 0f);
            pinon++;
            down = false;
        }

        if (pinon == 1)
        {
            Pinones.SetInteger("State", 1);
        }
        if (pinon == 2)
        {
            Pinones.SetInteger("State", 2);
        }
        if (pinon == 3)
        {
            Pinones.SetInteger("State", 3);
        }
        if (pinon == 4)
        {
            Pinones.SetInteger("State", 4);
        }
        if (pinon == 5)
        {
            Pinones.SetInteger("State", 5);
        }
        if (pinon == 6)
        {
            Pinones.SetInteger("State", 6);
        }
        if (pinon == 7)
        {
            Pinones.SetInteger("State", 7);
        }
        if (pinon == 8)
        {
            Pinones.SetInteger("State", 8);
        }
        if (pinon == 9)
        {
            Pinones.SetInteger("State", 9);
        }
        if (pinon == 10)
        {
            Pinones.SetInteger("State", 10);
        }

        if (final == true && Antena.transform.rotation == Quaternion.Euler(0, 0, -20f) && pinon != 10)
        {
            Win.gameObject.SetActive(true);
            Next.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
        if (pinon == 10 )
        {
            Lose.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
        if (final == true && Antena.transform.rotation != Quaternion.Euler(0, 0, -20f) )
        {
            Lose.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            BotonBajar.gameObject.SetActive(false);
            BotonSubir.gameObject.SetActive(false);
            BotonEnter.gameObject.SetActive(false);
        }
    }
}
