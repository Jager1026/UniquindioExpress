using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundControllerDesert : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("suelo"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("suelo"))
        {
            isGrounded = false;
        }
    }
}