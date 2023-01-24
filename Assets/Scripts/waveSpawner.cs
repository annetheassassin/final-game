using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public static int EnemiesAlive = 0;

    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 0f;
    
    public Text EnemiesAliveText;
    public Text waveCountDownText;
    public float nrofEnemies = 0;

    private int waveIndex = 0;

    void Update () 
    {
        if (EnemiesAlive > 0)
        {
            return;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        waveCountDownText.text = Mathf.Ceil(countdown).ToString();
        countdown -= Time.deltaTime;

        
        EnemiesAliveText.text = Mathf.Ceil(nrofEnemies).ToString();

    }

    /*void CountnrofEnemies()
    {
        Wave wave = waves[0];
         for (int z = 0; z < wave.enemies.Length; z++)
            {
            for (int i = 0; i < wave.enemies[z].count; i++)
            {
                nrofEnemies = nrofEnemies + wave.enemies[z].count;
            }
         }
    }
   */

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
        for (int z = 0; z < wave.enemies.Length; z++)
        {
            for (int i = 0; i < wave.enemies[z].count; i++)
            {
                SpawnEnemy(wave.enemies[z].enemy);
                yield return new WaitForSeconds(1f / wave.spawnRate);
            }
            if (waveIndex == waves.Length)
            {
                Debug.Log("TODO - End Level");
                this.enabled = false;
            }
        }
        waveIndex++;
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }
}
