using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroHielo : MonoBehaviour
{
    public GameObject BotonNext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
