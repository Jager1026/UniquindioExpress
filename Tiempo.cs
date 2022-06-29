using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public float tiempo = 20.0f;
    public GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer = GameObject.FindGameObjectWithTag("Time");
        tiempo -= Time.deltaTime;
        if (tiempo < 0.0f)
        {
            Timer.GetComponent<Animator>().SetBool("TimeOut", false);
        }
    }
}
