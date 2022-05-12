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
    public GameObject nube1;
    public GameObject nube2;

    public float velocidadMonedas = 0.5f;

    public bool start;
    public bool finish;

    public float spawnRate;
    public float lastSpawn;

    public float spawnRateCloud;
    public float LastSpawnCloud;

    public float tiempoMision = 60;

    public score puntaje;

    //public Puntaje puntaje;

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

            //se establece el limite de tiempo de la mision
            tiempoMision -= Time.deltaTime;

            //aqui se termina el tiempo
            if (tiempoMision <= 0.0f)
            {
                //pasamos bool a true, significa que el juego ha terminado
                finish = true;
            }

            // se generan numeros aletorios
            float randomCoins = Random.Range(-3, 5);

            float randomClouds1Y = Random.Range(1.5f, 5);
            float randomClouds2Y = Random.Range(1.5f, 5);

            float randomClouds1X = Random.Range(13, 15);
            float randomClouds2X = Random.Range(13, 15);
            //mover el fondo
            fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.2f, 0) * Time.deltaTime;

            if (Time.time - spawnRateCloud >= LastSpawnCloud)
            {
                LastSpawnCloud = Time.time;
                //instanciamos las nubes
                Instantiate(nube1, new Vector3(randomClouds1X, randomClouds1Y, 0), Quaternion.identity);

                LastSpawnCloud = Time.time;
                Instantiate(nube2, new Vector3(randomClouds2X, randomClouds2Y, 0), Quaternion.identity);
            }
            //determinamos el tiempo de respawn
            if (Time.time - spawnRate >= lastSpawn)
            {
                //tiempo de gracia entre spawn de monedas
                lastSpawn = Time.time;

                //se crea una nueva moneda en un lugar aletorio
                Instantiate(moneda, new Vector3(10, randomCoins, 0), Quaternion.identity);

            }

            //Extreme Sport Trap Music | PISTA by Alex-Productions | https://www.youtube.com/channel/UCx0_M61F81Nfb-BRXE-SeVA
            //Music promoted by https://www.chosic.com/free-music/all/
            //Creative Commons CC BY 3.0
            //https://creativecommons.org/licenses/by/3.0/

            //https://patrickdearteaga.com
        }
    }
}
