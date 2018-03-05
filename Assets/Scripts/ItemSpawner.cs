using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {


    public Transform[] spawnPoints;
    public GameObject coinPrefab;
    public GameObject lollipopPrefab;
    public GameObject bagPrefab;
    public GameObject prjPrefab;
    public GameObject poisonPrefab;
    public float timeBetweenSpawn;
    public float timeToSpawn;
    
    void Start () {
		
	}
	
	
	void Update () {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenSpawn;
        }

    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomItem = Random.Range(0, 100);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                if (randomItem >= 0 && randomItem < 3)
                {
                    Instantiate(bagPrefab, spawnPoints[i].position, Quaternion.identity);
                }

                if (randomItem >= 3 && randomItem < 5)
                {
                    Instantiate(poisonPrefab, spawnPoints[i].position, Quaternion.identity);
                }

                if (randomItem >= 5 && randomItem <8)
                {
                    Instantiate(prjPrefab, spawnPoints[i].position, Quaternion.identity);
                }

                if (randomItem >= 8 && randomItem < 10)
                {
                    Instantiate(lollipopPrefab, spawnPoints[i].position, Quaternion.identity);
                }

                if (randomItem >= 10 && randomItem <= 100)
                {
                    Instantiate(coinPrefab, spawnPoints[i].position, Quaternion.identity);
                }
            }
        }
    }
}
