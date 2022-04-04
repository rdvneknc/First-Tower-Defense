using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public float timeBetweenWaves = 5f;
    private float countDown = 2f;

    private void Update()
    {
        if(countDown <= 0)
        {
            SpawnEnemyWave();
            countDown = timeBetweenWaves;
        }

        countDown -= Time.deltaTime;

    }

    void SpawnEnemyWave()
    {
        Debug.Log("Wave Incoming");
    }
}
