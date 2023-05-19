using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject[ ] powerupPrefabs; 
   private float spawnRangeX = 500; 
   private float spawnRangeZ = 500;
   private float startDelay = 1;
   private float spawnInterval = 1.5f;

   // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPowerup",startDelay,spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.S))
       {
        SpawnRandomPowerup();
       } 
    } 
    
    void SpawnRandomPowerup()
    {
     int powerupIndex = Random.Range (0, powerupPrefabs.Length);
        Vector3 spawnRange= new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, Random.Range(-spawnRangeZ, spawnRangeZ)); 

        Instantiate(powerupPrefabs[powerupIndex], spawnRange, powerupPrefabs[powerupIndex].transform.rotation);  
    }
}
