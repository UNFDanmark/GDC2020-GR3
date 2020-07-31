using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public int nrOfEnemies = 0;
    public Transform[] Spawn;

    // Start is called before the first frame update
    void Start()
    {
        //if (int i = 0; i > nrOfEnemies;)
        //{
        //    SpawnEnemy();
        //}

        //while (nrOfEnemies == 2)
        //{
        //    SpawnEnemy();
        //}

        //if (nrOfEnemies < 4)
        //{
        //    SpawnEnemy();
        //}

        for (int i = 0; i < 2; i++)
        {
            SpawnEnemy();
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       
    }

    public void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(EnemyPrefab);
        //Enemy enemyScript = newEnemy.GetComponent<Enemy>();
        //enemyScript.player = 

        newEnemy.transform.position = Spawn[Random.Range(0, Spawn.Length)].position;
    }
}
