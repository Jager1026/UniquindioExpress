using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
    
{
    //private Rigidbody rigidbody;
    public Vector3 moveDir;         // direction to move in
    public float moveSpeed;         // speed to move at along moveDir
    public float time;
    public bool Water;
    public bool Ice;
    public bool Fire;
    public bool Air;
    public bool Gas;
    public bool Desert;
    public int numeroEscena = 6;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    public int playerOption;
    
    
    

    // Start is called before the first frame update
    void Start()
    {   
        playerOption = GameManager.Instance.Option;
        //playerOption = GameManager.Instance.index;
        //Debug.Log("Player_es: "+playerOption);
        Character character = characterDB.GetCharacter(playerOption);
        
        artworkSprite.sprite = character.characterSprite;
        //Debug.Log("Player: "+playerOption);
        //
    
        //playerOption = Option;
        //Character character = characterDB.GetCharacter(playerOption);
        //artworkSprite.sprite = character.characterSprite;
       // rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Water)
        {
            StartCoroutine(Agua());
        }

    }

    IEnumerator Agua() {
        
        Water = false;
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-7.59f, -1.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-6.59f, -1.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-5.05f, -1.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-5.05f, -2.54f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-5.05f, -3.32f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-4.25f, -3.32f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-3.56f, -3.32f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.81f, -3.32f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.81f, -2.42f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.81f, -1.32f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.81f, -0.71f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.81f, 0.31f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-0.58f, 0.31f, -1.164247f);
        SceneManager.LoadScene(numeroEscena);
        //Ice = true;
     }
    
}
