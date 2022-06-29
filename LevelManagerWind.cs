using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerWind : MonoBehaviour
{
    public static LevelManagerWind instance;
    public GameObject MenuCompleteWind;
    public GameObject MenuStartWind;
    public GameObject MenuLostWind;

    public GameObject Tornadowind;

    public bool start;
    public bool finish;

    public float spawnRate;
    public float lastSpawn;

    private void Awake()
    {
        instance=this ;
    }

    // Start is called before the first frame update
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            //se activa el menu de inicio de mision
            MenuStartWind.SetActive(true);

            // Menu de iniciar mision
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
                MenuStartWind.SetActive(false);
            }
        }

        // si la mision se termina
        if (playerFallControllerWind.instance.meta == true && start == true && !PlayerHealthControllerWind.instance.playerLost && !playerFallControllerWind.instance.Falled)
        {
            //Control del Menu de termino de mision
            MenuCompleteWind.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                //se reinicia la mision
                //SceneManager.LoadScene();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            }

        }

        float randomTornado = Random.Range(0, 80);

        if (start == true && playerFallControllerWind.instance.meta == false && !PlayerHealthControllerWind.instance.playerLost && !playerFallControllerWind.instance.Falled)
        {
            if (Time.time - spawnRate >= lastSpawn)
            {
                //tiempo de gracia entre spawn de monedas
                lastSpawn = Time.time;

                //se crea una nueva moneda en un lugar aletorio
                Instantiate(Tornadowind, new Vector3(randomTornado, 6, 0), Quaternion.identity);

            }
        }

        if (start == true && playerFallControllerWind.instance.meta == false && (PlayerHealthControllerWind.instance.playerLost || playerFallControllerWind.instance.Falled))
        {
            MenuLostWind.SetActive(true);

            if (Input.GetKeyDown(KeyCode.X))
            {
                //se reinicia la mision
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
