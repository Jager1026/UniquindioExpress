using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveAire : MonoBehaviour
{
    public bool Air = true;
    public int playerOption;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
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
        if (Air)
        {
            StartCoroutine(Aire());
        }
    }

    IEnumerator Aire()
    {
        Air = false;

        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.76f, 1.4f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.76f, 1.0f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.76f, 0.6f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.06f, 0.6f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.46f, 0.6f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.86f, 0.6f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.91f, 0.18f, -1.164247f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
