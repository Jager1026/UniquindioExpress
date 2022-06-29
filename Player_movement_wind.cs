using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement_wind : MonoBehaviour
{
    // Start is called before the first frame update


    //private Animator animator;
    private Rigidbody2D rb2D;

    [Header("Movimiento")]
    private float movimientoHorizontal = 0.0f;
    [SerializeField] private float velocidadMovimiento;
    [Range(0, 0.3f)][SerializeField] private float suavizadoMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;

    [Header("Salto")]
    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Vector2 dimesionesCaja;
    [SerializeField] private bool enSuelo;
    [SerializeField] private Transform controladorSuelo;
    private bool salto = false;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    public int playerOption;

    void Start()
    {
        playerOption = GameManager.Instance.Option;
        //playerOption = Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
        //animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal")*velocidadMovimiento;
        //animator.SetFloat("horizontal", Mathf.Abs(movimientoHorizontal));

        if (Input.GetButtonDown("Jump"))
        {
            salto = true;
        }
       
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimesionesCaja,0f, queEsSuelo);
        //animator.SetBool("isJumping", !enSuelo);

        //mover personaje
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;
        
    }

    private void Mover(float mover, bool saltar)
    {
        if (LevelManagerWind.instance.start == true) {
            Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
            rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoMovimiento);


            if (mover > 0 && !mirandoDerecha)
            {
                Girar();

            }

            else if (mover < 0 && mirandoDerecha)
            {
                Girar();

            }

            if (enSuelo && saltar)
            {
                enSuelo = false;
                rb2D.AddForce(new Vector2(0.0f, fuerzaDeSalto));
            }
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(controladorSuelo.position,dimesionesCaja);
    }

}
