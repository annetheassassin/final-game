using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class waveSpawner : MonoBehaviour
{
    public Wave[] waves;
 
    private Wave currentWave;
 
    [SerializeField]
    private Transform[] spawnpoints;
 
    private float timeBtwnSpawns;
    private int i = 0;
 
    private bool stopSpawning = false;
 
    private void Awake()
    {
 
        currentWave = waves[i];
        timeBtwnSpawns = currentWave.TimeBeforeThisWave;
    }
 
    private void FixedUpdate()
    {
        if(stopSpawning)
        {
            return;
        }
 
        if (Time.time >= timeBtwnSpawns)
        {
            SpawnWave();
            IncWave();
 
            timeBtwnSpawns = Time.time + currentWave.TimeBeforeThisWave;
        }
    }
 
    private void SpawnWave()
    {
        for (int i = 0; i < currentWave.numberToSpawn; i++)
        {
            int num = Random.Range(0, currentWave.EnemiesInWave.Length);
            new WaitForSeconds(1);
            int num2 = Random.Range(0, spawnpoints.Length);
 
            Instantiate(currentWave.EnemiesInWave[num], spawnpoints[num2].position, spawnpoints[num2].rotation);
         
        }
    }
 
    private void IncWave()
    {
        if (i + 1 < waves.Length)
        {
            i++;
            currentWave = waves[i];
        }
        else
        {
            stopSpawning = true;
        }
    }
}