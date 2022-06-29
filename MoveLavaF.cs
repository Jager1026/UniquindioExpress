using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveLavaF : MonoBehaviour
{

    public bool Fire = true;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    public int playerOption;
    // Start is called before the first frame update
    void Start()
    {
        playerOption = GameManager.Instance.Option;
        //playerOption = Option;
        Character character = characterDB.GetCharacter(playerOption);
        artworkSprite.sprite = character.characterSprite;
    }

    // Update is called once per frame
    void Update()
    {
         if (Fire)
             {
               StartCoroutine(Lava());
             }
    }

    IEnumerator Lava()
        {
            Fire = false;
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -2.95f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -2.55f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -2.15f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -1.75f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -1.35f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -0.95f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -0.55f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, -0.15f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, 0.25f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.05f, 0.60f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.45f, 0.6f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(2.85f, 0.6f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(3.25f, 0.6f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(3.76f, 0.6f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(3.76f, 1.0f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(3.76f, 1.4f, -1.164247f);
            yield return new WaitForSeconds(1);
            transform.position = new Vector3(3.76f, 1.62f, -1.164247f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }
}
