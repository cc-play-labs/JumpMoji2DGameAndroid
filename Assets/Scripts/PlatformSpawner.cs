using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {


    public float lastPos;
    public float distanceCheck;
    public float highPointStore;

    public Transform[] spawnPoints;
    public Transform highPoint;
    public GameObject[] platPrefabs;
    public GameObject Player;
    
    [SerializeField]
    private bool canSpawn;
   
    void Start () {
        lastPos = -3.8f;
    }
	
	
	void Update () {
        highPointStore = highPoint.position.y;
        if (highPointStore - lastPos > distanceCheck)
        {
            canSpawn = true;

        }
        if(canSpawn)
        {
            SpawnPlatforms();
            
        }

       // Debug.Log(Player.transform.position.y);
        
	}

    void SpawnPlatforms()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                lastPos = spawnPoints[i].position.y;
                Debug.Log(lastPos);
                Instantiate(platPrefabs[0], spawnPoints[i].position, Quaternion.identity);
                canSpawn = false;
            }
        }
    }
}
