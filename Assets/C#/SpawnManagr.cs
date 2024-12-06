using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] snackPrefabs;


    private float spawnPosY = 5.63f;
    private float xRange=  5.12f;
    private float zRange;
    private float startDelay = 0.1f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSnack", startDelay, spawnInterval);
    }

    // Spawn random snack at random x position at top of play area
    void SpawnRandomSnack ()
    {
        // Generate random snack index and random spawn position
       int snackIndex = Random.Range(0, snackPrefabs.Length);
       
        Vector3 spawnPos = new Vector3(Random.Range(-5.86f,4.03f),10,Random.Range(-4.3f, 5.7f));
        // instantiate snack at random spawn location
        Instantiate(snackPrefabs[snackIndex], spawnPos, snackPrefabs[snackIndex].transform.rotation);
    }

}