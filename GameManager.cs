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
    public float velocidad = 2;
    public List<GameObject> monedas;
    public bool start;
    public bool finish;

    // Start is called before the first frame update
    void Start()
    {
        start = false;
        monedas.Add(Instantiate(moneda, new Vector2(10, 0),Quaternion.identity));
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
        if (finish == true && start == true)
        {
            MenuComplete.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (start == true && finish == false)
        {
            fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.2f, 0) * Time.deltaTime;

            //Mover monedas
            for (int i = 0; i < monedas.Count; i++)
            {
                if (monedas[i].transform.position.x <= -10)
                {
                    //monedas[i].transform.position = new Vector3(10, -3, 0);
                    float randomCoins = Random.Range(10, 18);
                    monedas[i].transform.position = new Vector3(randomCoins, -2, 0);
                }
                monedas[i].transform.position = monedas[i].transform.position + new Vector3(-3, 0, 0) * Time.deltaTime * velocidad;

            }
        }
    }
}
