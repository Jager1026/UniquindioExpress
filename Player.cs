using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float Speed;
	public new Rigidbody2D rigidbody2D;

	private float Horizontal;
	private float Vertical;
	public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
	[SerializeField] private float cantidadPuntosTotales;
	public int playerOption;

	private float CantidadPuntos;
	[SerializeField] private score puntaje;

	//Start is called before the first frame update
	void Start()
	{
		playerOption = GameManager.Instance.Option;
        //playerOption = Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
		rigidbody2D = GetComponent<Rigidbody2D>();
	}

	//Update is called once per frame

	void Update()
	{
		float horizontal = Input.GetAxis("Horizontal");

		float vertical = Input.GetAxis("Vertical");

		rigidbody2D.velocity = new Vector2(vertical * Speed, rigidbody2D.velocity.y);
		rigidbody2D.velocity = new Vector2(horizontal * Speed, rigidbody2D.velocity.x);
		//float Vertical = Input.GetAxisRaw("Vertical");

		//if (Input.GetKeyDown(KeyCode.W))
		//{
		//	rigidbody2D.AddForce(new Vector2(0, Speed));
		//}
	}

	private void FixedUpdate()
	{
		// Aplicar Freeze Rotation Z en el apartado Rigidbody2D
		//rigidbody2D.velocity = new Vector2(Horizontal * Speed, Vertical * Speed);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		
		
		if (other.CompareTag("moneda"))
		{
			puntaje.SumarPuntos(10);
			cantidadPuntosTotales = 10;
			ControladorPuntosTotales.Instance.SumarPuntos(cantidadPuntosTotales);
		}

	}
}
