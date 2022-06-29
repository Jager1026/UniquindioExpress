using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlataform : MonoBehaviour
{
    public GameObject ObjetoMover;
    public Transform StartPoint;
    public Transform FinishPoint;
    public float velocidad;

    private Vector3 moverHacia;

    // Start is called before the first frame update
    void Start()
    {
        moverHacia = FinishPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoMover.transform.position = Vector3.MoveTowards(ObjetoMover.transform.position, moverHacia, velocidad * Time.deltaTime); 

        if(ObjetoMover.transform.position == FinishPoint.position)
        {
            moverHacia = StartPoint.position;
        }
        else if (ObjetoMover.transform.position == StartPoint.position)
        {
            moverHacia = FinishPoint.position;
        }
    
    }
}
