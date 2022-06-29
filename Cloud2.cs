using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cloud2 : MonoBehaviour
{
    // Start is called before the first frame update

    //public Vector3 moveDir;         // direction to move in
    public float moveSpeed = 0.7f;         // speed to move at along moveDir
    public float Timetolive = 25f;


    // private float aliveTime = 8.0f; // time before object is destroyed
    void Start()
    {
        Destroy(gameObject, Timetolive);
    }

    public void move()
    {
        //se mueve la moneda
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        //se mueve la moneda
        gameObject.transform.position = gameObject.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * moveSpeed;

    }

}
