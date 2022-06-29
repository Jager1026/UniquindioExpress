using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerDesert : MonoBehaviour
{
    public GameObject col;
    public GameObject tornado;
    public GameObject MenuComplete;
    public GameObject MenuStart;
    public GameObject MenuLost;
    public static LevelManagerDesert Instance;
    [SerializeField] private float cantidadPuntosTotales;

    public float velocidad = 2;
    public float lastSpawn;
    public float spawnRate;
    public float TiempoMision = 60;

    public bool start;
    public bool finish;
    public bool lost;

    public List<GameObject> cols;

    //public LifeManager lifeManager;

    // Start is called before the first frame update
    
    private void Awake()
    {
        LevelManagerDesert.Instance = this;
    }
    
    void Start()
    {
        lost = false;
        start = false;

        //crear mapa
        for (int i = 0; i < 25; i++)
        {
            cols.Add(Instantiate(col, new Vector2(-8.6f + i, -5.3f), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            MenuStart.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
                MenuStart.SetActive(false);
            }
        }

        if (start == true && finish == false)
        {

            TiempoMision -= Time.deltaTime;

            if (TiempoMision <= 0.0f)
            {
                //pasamos bool a true, significa que el juego ha terminado
                finish = true;
            }

            for (int i = 0; i < cols.Count; i++)
            {
                if (cols[i].transform.position.x <= -10)
                {
                    cols[i].transform.position = new Vector3(15f, -5.3f, 0);
                }
                cols[i].transform.position = cols[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * velocidad;
            }

            if (Time.time - spawnRate >= lastSpawn)
            {
                float randomTornado = Random.Range(13, 15);

                //tiempo de gracia entre spawn de monedas
                lastSpawn = Time.time;

                //se crea una nueva moneda en un lugar aletorio
                Instantiate(tornado, new Vector3(randomTornado, -2.3f, 0), Quaternion.identity);

            }
        }

        if (start == true && finish == true)
        {
            MenuComplete.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            cantidadPuntosTotales = 200;
            ControladorPuntosTotales.Instance.SumarPuntos(cantidadPuntosTotales);
        }

        if (start == true && finish == false && PlayerHealthControllerDesert.instance.currentHealth <= 0)
        {
            MenuLost.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    //M�sica autor: <a href="https://soundcloud.com/alessandro-ricci-834177656">Alessandro Ricci</a><br>
    //T�tulo de m�sica : Africa<br/>
    //Licencia : <a href = "https://creativecommons.org/licenses/by-nc-sa/4.0/deed.es" > CC BY-NC-SA</a><br/>
    //Descargar : <a href = "https://lamusicagratis.com/musica/instrumental" > musica instrumental</a>
    //creditos a David Fau y Javier Ribes por insturmentales de Night
}