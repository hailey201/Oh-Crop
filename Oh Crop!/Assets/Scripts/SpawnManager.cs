using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
   


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            int powerupIndex = Random.Range(0,4);

            Instantiate(powerupPrefabs[powerupIndex], new Vector3(0,0,20), powerupPrefabs[powerupIndex].transform.rotation);
        }
    }

}
   