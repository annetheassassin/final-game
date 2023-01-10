using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    void Awake() { instance = this; }

    public EnemySpawner spawner;

    void Start() 
    {
       StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        //Wait for x secondes
        yield return new WaitForSeconds(2f);
        //Start the enemy spawning
        GetComponent<EnemySpawner>().StartSpawning();
    }
}
