using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento_prueba : MonoBehaviour
{
    
   
    public float rapidez;
    public float JumpForce;
    private Rigidbody2D Rigi2d;
    private bool mirandoDerecha = true;
    private BoxCollider2D boxCollider;
    public LayerMask capaSuelo;
    public int saltosMaximos;
    public int saltosRestantes;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
	public int playerOption;
    Vector3 initPosition;
    public GameObject MenuCompleteSnow;
    public bool Puntaje = false;
    public static Movimiento_prueba Instance;
    [SerializeField] public bool llegoFinal = false;


    private void Awake()
    {
        Instance = this;
    }
    
    private void Start()
    {
        playerOption = GameManager.Instance.Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
        Rigi2d = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        saltosRestantes = saltosMaximos;
        initPosition = this.transform.position;

    }
    // Update is called once per frame
     void Update()
    {
        ProcesarMovimiento();
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

     void ProcesarMovimiento()
    {
        float InputMovimiento = Input.GetAxis("Horizontal");
        Rigi2d.velocity = new Vector2(InputMovimiento*rapidez, Rigi2d.velocity.y);
        GestionarOrientacion (InputMovimiento);

    }

     bool EstaEnSuelo()
    {
        RaycastHit2D rayCastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, capaSuelo);
        return rayCastHit.collider != null;
    }

     void Jump()
    {
        if (EstaEnSuelo())
        {
            saltosRestantes = saltosMaximos;
        }

        if (Input.GetKeyDown(KeyCode.W) && saltosRestantes > 0)
        {
            saltosRestantes--;
            Rigi2d.velocity = new Vector2(Rigi2d.velocity.x, 0f);
            Rigi2d.AddForce(Vector2.up * JumpForce); 
        }

        
        
    }

    void  GestionarOrientacion(float InputMovimiento)
    {
        if((mirandoDerecha == true && InputMovimiento < 0)||(mirandoDerecha == false && InputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2 (-transform.localScale.x, transform.localScale.y);

        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Crystal"))
        {
            Debug.Log("Quita vida");
            this.transform.position = initPosition;
            
        }
        if(collision.collider.CompareTag("Plataformas"))
        {
            saltosRestantes = saltosMaximos;
            Debug.Log("saltos restantes 2");
        }

        if(collision.collider.CompareTag("metafinal") || llegoFinal == true)
        {
             Puntaje = true;
             MenuCompleteSnow.SetActive(true);
             llegoFinal = true;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            
        }
    }
}
