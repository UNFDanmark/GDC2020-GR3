using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public int nrOfEnemies = 2;

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i > nrOfEnemies; i++)
        //{
        //    SpawnEnemy();
        //}
        
        while (nrOfEnemies < 2)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(EnemyPrefab);

        newEnemy.transform.position = new Vector2(Random.Range(-6f, 11f), Random.Range(-6f, 11f));
    }
}
