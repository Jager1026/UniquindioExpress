using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDesierto : MonoBehaviour
{
    public bool Desert = true;
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
        if (Desert)
        {
            StartCoroutine(Desierto());
        }
    }

    IEnumerator Desierto()
    {
        Desert = false;
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.07f, 0.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.47f, 0.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, 0.74f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, 0.44f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, -0.04f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, -0.44f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, -0.84f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.65f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-1.25f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-0.85f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-0.45f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(-0.05f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(0.45f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(0.85f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(1.25f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(1.65f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -1.35f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -1.75f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -2.15f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -2.55f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -2.95f, -1.164247f);
        yield return new WaitForSeconds(1);
        transform.position = new Vector3(2.05f, -3.31f, -1.164247f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
