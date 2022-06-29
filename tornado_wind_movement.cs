using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornado_wind_movement : MonoBehaviour
{

    [SerializeField] private float timeTolive;
    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeTolive);
    }

    public void move()
    {
        //se mueve el tornado
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "void")
        {

            Destroy(gameObject);
        }
    }

}
