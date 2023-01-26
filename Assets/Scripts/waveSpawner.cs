using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 0f;
    public static float countdown = 15f;
    
    public Text EnemiesAliveText;
    public Text waveCountDownText;
    public static int nrofEnemies = 0;

    private int waveIndex = 0;

    void Update () 
    {
        if (countdown < 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        waveCountDownText.text = Mathf.Ceil(countdown).ToString();
        countdown -= Time.deltaTime;

        EnemiesAliveText.text = Mathf.Ceil(nrofEnemies).ToString();


    }

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
        for (int z = 0; z < wave.enemies.Length; z++)
        {
            //update enemies alive
            nrofEnemies = nrofEnemies + wave.enemies[z].count;
            Debug.Log("nr of enemies" + nrofEnemies);
            EnemiesAliveText.text = Mathf.Ceil(nrofEnemies).ToString();

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
    }
}
