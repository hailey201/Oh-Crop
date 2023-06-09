using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cropPrefab;
    public GameObject coinPrefab;
    public GameObject daikonPrefab;
    public float spawnRange = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cropPrefab, GenerateSpawnPosition(), cropPrefab.transform.rotation);
        Instantiate(coinPrefab, GenerateSpawnPosition(), coinPrefab.transform.rotation);
        Instantiate(daikonPrefab, GenerateSpawnPosition(), daikonPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

}
