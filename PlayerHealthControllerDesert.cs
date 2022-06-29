using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthControllerDesert : MonoBehaviour
{
    public int currentHealth, maxHealth;
    public static PlayerHealthControllerDesert instance;

    [SerializeField] private LifeBar lifebar;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        lifebar.InicializarBarraVida(currentHealth);
        currentHealth = maxHealth;
    }

    public void takeDamage()
    {
        currentHealth--;
        lifebar.CambiarVidaActual(currentHealth);
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
