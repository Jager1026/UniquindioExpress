using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthControllerWind : MonoBehaviour
{
    public int currentHealth, maxHealth;
    public bool playerLost;
    public static PlayerHealthControllerWind instance;

    [SerializeField] private LifeBarWind lifebar;

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
            playerLost = true;
        }
    }
}