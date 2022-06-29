using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveGas : MonoBehaviour
{
    public bool Gas = true;
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
        if (Gas)
        {
            StartCoroutine(Gaseoso());
        }
    }

    IEnumerator Gaseoso()
    {
        Gas = false;

        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.86f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.46f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.06f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.66f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.26f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.86f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.46f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, 0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, 0.07f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, -0.47f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, -0.87f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, -1.27f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.06f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.56f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.06f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(3.56f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.06f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(4.56f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(5.06f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(5.56f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.06f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -1.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -1.83f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -2.23f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -2.63f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -3.03f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -3.43f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -3.83f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(6.34f, -4.09f, -1.164247f);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);




    }
}
