using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limpiar : MonoBehaviour
{
    public int State = 1;
    public bool Clean = false;
    public GameObject CleanButton;
    public Animator Arena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickClean()
    {
        Clean = true;
    }
    // Update is called once per frame
    void Update()
    {
        Arena = GetComponent<Animator>();
        if (Clean)
        {
            State++;
            Clean = false;
        }

        if (State == 2)
        {
            Arena.SetInteger("Next", 2);
        }
        if (State == 3)
        {
            Arena.SetInteger("Next", 3);
        }
        if (State == 4)
        {
            Arena.SetInteger("Next", 4);
        }
        if (State == 5)
        {
            Arena.SetInteger("Next", 5);
        }
        if (State == 6)
        {
            Arena.SetInteger("Next", 6);
        }
        if (State == 7)
        {
            Arena.SetInteger("Next", 7);
        }
        if (State == 8)
        {
            Arena.SetInteger("Next", 8);
        }
        if (State == 9)
        {
            Arena.SetInteger("Next", 9);
        }
        if (State == 10)
        {
            Arena.SetInteger("Next", 10);
        }
        if (State == 11)
        {
            Arena.SetInteger("Next", 11);
        }
    }
}
