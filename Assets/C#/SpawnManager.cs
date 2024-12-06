using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] snackPrefabs;

    private float spawnLimitXLeft = -10f;
    private float spawnLimitXRight = 250f;
    private float spawnLimitZLeft = -10;
    private float spawnLimitZRight = 200;
    private float spawnPosY = 50;
   
    private float startDelay = 1.0f;
    private float spawnInterval = 0.5f;

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
       
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft,spawnLimitXRight),spawnPosY,Random.Range(spawnLimitZLeft, spawnLimitZRight));
        // instantiate snack at random spawn location
        Instantiate(snackPrefabs[snackIndex], spawnPos, snackPrefabs[snackIndex].transform.rotation);
    }

}