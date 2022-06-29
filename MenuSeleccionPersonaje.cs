using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonaje : MonoBehaviour
{
    public int index;
    public int indicativo = 0;
    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;
    private GameManager gameManager;
    public static MenuSeleccionPersonaje instance;

    public AudioClip sound;

     private void Awake()
    {
        instance=this;

    }
 

    private void Start()
    {
        
        gameManager = GameManager.Instance;
        index = PlayerPrefs.GetInt("JugadorIndex");
        if (index > gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        gameManager.index=index;
        CambiarPantalla();
    }
    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex", index);
        indicativo = index;
        imagen.sprite = gameManager.personajes[indicativo].imagen;
        nombre.text = gameManager.personajes[indicativo].nombre;
        
    }
    public void SiguientePersonaje()
    {
        if(index == gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }
        CambiarPantalla();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);

    }
    public void AnteriorPersonaje()
    {
        if (index == 0)
        {
            index = gameManager.personajes.Count - 1;
        }
        else
        {
            index -= 1;
        }
        CambiarPantalla();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }
    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
    }
    

}
