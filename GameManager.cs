using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject MenuComplete;
    public GameObject MenuStart;
    public Renderer fondo;

    public GameObject moneda;

    //private Coin coin;

    public float velocidadMonedas = 0.5f;
    //public List<GameObject> monedas;
    public bool start;
    public bool finish;

    public float spawnRate;
    public float lastSpawn;

    public float tiempoMision=20;

    public Puntaje puntaje; 

    // Start is called before the first frame update
    void Start()
    {
        start = false;
        //instanciamos la moneda
        //moneda(Instantiate(moneda, new Vector2(10, 0),Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        // si no ha iniciado el juego
        if (start == false)
        {
            //se activa el menu de inicio de mision
            MenuStart.SetActive(true);
            // Menu de iniciar mision
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
                MenuStart.SetActive(false);
            }    
        }
        // si la mision se termina
        if (finish == true && start == true)
        {   
            //Control del Menu de termino de mision
            MenuComplete.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                //se reinicia la mision
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        //Inicia la mision
        if (start == true && finish == false)
        {
            //llama al metodo agregarPuntos
            puntaje.agregarPuntos();

            //se establece el limite de tiempo de la mision
            tiempoMision -= Time.deltaTime;
            if (tiempoMision <= 0.0f)
            {
                finish = true;
            }

            // se generan numeros aletorios
            float randomCoins = Random.Range(-3, 5);

            //mover el fondo
            fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.2f, 0) * Time.deltaTime;
            //moneda.transform.position = moneda.transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * velocidadMonedas;
           //coin.move();

            if (Time.time - spawnRate >= lastSpawn)
            {
                //tiempo de gracia entre spawn de moendas
                lastSpawn = Time.time;
                //se crea una nueva moneda en un lugar aletorio
                Instantiate(moneda, new Vector3(10, randomCoins, 0), Quaternion.identity);
            }

            //Extreme Sport Trap Music | PISTA by Alex-Productions | https://www.youtube.com/channel/UCx0_M61F81Nfb-BRXE-SeVA
//Music promoted by https://www.chosic.com/free-music/all/
//Creative Commons CC BY 3.0
//https://creativecommons.org/licenses/by/3.0/
            //generar monedas

            //moneda.transform.position = new Vector3(randomCoins, -2, 0);
            //moneda.transform.position = moneda.transform.position + new Vector3(0, -3, 0) * Time.deltaTime * velocidadMonedas;

            //Mover monedas
            // for (int i = 0; i < monedas.Count; i++)
            //{
            // if (monedas[i].transform.position.x <= -10)
            //{
            //moneda.transform.position = new Vector3(10, -3, 0);
            //   float randomCoins = Random.Range(-3, 5);
            //moneda.transform.position = new Vector3(randomCoins, -2, 0);
            //  moneda.transform.position = new Vector3(10, randomCoins, 0);
            //}



            //}
        }
    }
}
