using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int enemiesLeft;
    Vector2 spawnPosition;
    int [] enemiesSpawned = new int[] { 1, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
    public int randInd;
    int randNum;
    int randX;

    public void SpawnRandom()
    {
        //randX = Random.Range(-7, -2);
        randInd = Random.Range(0, enemiesSpawned.Length - 1);
        randNum = enemiesSpawned[randInd];
        for (int i = 0; i<= randNum; i++)
        {
            GameObject a = Instantiate(enemy) as GameObject;
            a.transform.position = new Vector2(-7 + i * 2, 2);


        }

        /*for ( if = 0; if <= randInd; i++){
            print('hi');
        }*/
      

    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", 0.1f, 4.0f);




    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
