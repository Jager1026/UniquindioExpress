using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimientoapersonaje : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [Header("Movimiento")]
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadDeMovimiento;
    [SerializeField] private float suavizadoDeMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
	public int playerOption;

    [Header("Salto")]
    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;
    private bool salto = false;

    public GameObject MenuInicioLavaP2;
    public GameObject MenuFinalLavaP2;
    public GameObject MenuPerderLavaP2;
    public bool start;
    public bool finish;
    public bool lost;

    //[Header("Animacion")]
    

    private void Start()
    {
        playerOption = GameManager.Instance.Option;
        //playerOption = Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
        lost = false;
        start = false;
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        if (start == false)
        {
            MenuInicioLavaP2.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
                MenuInicioLavaP2.SetActive(false);
            }
        }
        if (start == true && finish == false && VariadorDeVidaJugador.instance.vida > 0)
        {


            movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDeMovimiento;
            //animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));
            if (Input.GetButtonDown("Jump"))
            {
                salto = true;
            }
        }
        if (MetaMundoLava.instance.llego == true && finish==false && start==true)
        {
            //pasamos bool a true, significa que el juego ha terminado
            finish = true;
        }
        if (start == true && finish == true && VariadorDeVidaJugador.instance.vida > 0)
        {
            MenuFinalLavaP2.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
                //qui cargar la siguiente scene 
                //SceneManager.LoadScene("samplescene");
            }

        }
        if (start == true && finish == false && VariadorDeVidaJugador.instance.vida <= 0)
        {
            MenuPerderLavaP2.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        /*Debug.Log(start);
        Debug.Log(finish);
        Debug.Log(lost);*/
    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(controladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        //animator.SetBool("enSuelo", enSuelo);
        Moverse(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;
    }

    private void Moverse(float mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);

        if (mover > 0 && !mirandoDerecha)
        {
            Girar();
        }
        else if (mover < 0 && mirandoDerecha)
        {
            Girar();
        }
        if(enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDeSalto));
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
        Gizmos.DrawWireCube(controladorSuelo.position, dimensionesCaja);
    }
}


/*Dark Trap | DARKNESS by Alex-Productions | https://www.youtube.com/channel/UCx0_M61F81Nfb-BRXE-SeVA
Music promoted by https://www.chosic.com/
Creative Commons CC BY 3.0
https://creativecommons.org/licenses/by/3.0/
 u*/

