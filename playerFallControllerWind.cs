using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFallControllerWind : MonoBehaviour
{
    public static playerFallControllerWind instance;
    public bool Falled;
    public bool meta;

    private void Awake()
    {
        instance = this;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag =="void")
        {
            Falled = true;
        }

        if (other.gameObject.tag == "meta")
        {
            meta = true;
        }
    }
}
