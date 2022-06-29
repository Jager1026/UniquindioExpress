using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDesert : MonoBehaviour
{
    

    private new Rigidbody2D rigidbody2D;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
	public int playerOption;

    [Header("suelo")]
    [SerializeField] public float fuerzaSalto;
    [SerializeField] public bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        playerOption = GameManager.Instance.Option;
        //playerOption = Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
        
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        /* Debug.DrawRay(transform.position, Vector3.down * 0.9f, Color.red);

         if(Physics2D.Raycast(transform.position, Vector3.down * 0.9f))
         {
             grounded = true;
         }
         else grounded = false;*/
        if (Input.GetKeyDown(KeyCode.Space) && groundControllerDesert.isGrounded)
        {
            
            rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(0, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
           
        }
    }
}
