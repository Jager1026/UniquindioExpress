using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_hielo : MonoBehaviour
{
    [SerializeField] private float Speed;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal = 0f;
    private Vector3 velocidad = Vector3.zero;
    [SerializeField] private float suavizadoMovimiento;
    private bool mirandoDerecha = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal")* Speed;
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void Movimiento(float movimiento)
    {
        Vector3 velocidadObjeto = new Vector2 (movimiento, Rigidbody2D.velocity.y);
        Rigidbody2D.velocity = Vector3.SmoothDamp(Rigidbody2D.velocity, velocidadObjeto, ref velocidad, suavizadoMovimiento);
        
        if(movimiento > 0 && !mirandoDerecha)
        {
            Girar();
        }
        else if (movimiento < 0 && mirandoDerecha)
        {
            Girar();
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUPdate()
    {
        
        Movimiento (Horizontal * Time.fixedDeltaTime);
        
    }

}

