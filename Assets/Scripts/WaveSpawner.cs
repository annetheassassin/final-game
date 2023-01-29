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
    public Text waveCount;
    public static int nrofEnemies = 0;

    private int waveIndex = 0;

    void Update () 
    {
        if (countdown < 0f || (nrofEnemies == 0 && waveIndex > 0))
        {
            if (waveIndex != waves.Length)
            {
                PlayerStats.Money += 100;
                StartCoroutine(SpawnWave());
                waveIndex++;
                countdown = timeBetweenWaves;
                waveCount.text = waveIndex.ToString();
                return;
            }
            if (waveIndex == waves.Length && nrofEnemies == 0)
            {
                WinMenu.Pause();
                Debug.Log("Je hebt gewonnen!");
            }
            
        }
        EnemiesAliveText.text = Mathf.Ceil(nrofEnemies).ToString();
        if (waveIndex != waves.Length)
        {
            waveCountDownText.text = Mathf.Ceil(countdown).ToString();
            countdown -= Time.deltaTime;
        }
        else
        {
            waveCountDownText.text = "Final Wave";
        }
       


    }

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
        if(wave != null)
        {
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
            }
        }
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
