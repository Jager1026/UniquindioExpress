using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUp : MonoBehaviour
{
   public float timeSpawn = 2;
   public float repeatSpawn = 1;
   public GameObject[] enemies;


    void Start()
    {
        InvokeRepeating("SpawnEnemies", timeSpawn, repeatSpawn);
        //Destroy(gameObject,5);

    }

    public void SpawnEnemies()
    {
        Vector3 spawPosition = new Vector3(0,0,0);
        spawPosition = new Vector3(Random.Range(-25, -8), 25, 0);

        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)], spawPosition, gameObject.transform.rotation);
    
    }
}
