using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour
{
    public bool Siguiente = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickNext()
    {
        Siguiente = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
      public void ClickRetry()
    {
        Siguiente = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
