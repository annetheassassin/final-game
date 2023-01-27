using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    public int Damage;

    private buildManager buildManager;

    private Transform target;
    private int wavepointIndex = 0;

    //private buildManager BuildManager;

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex < Waypoints.points.Length - 1)
        {
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];

        }
        else
        {
            Destroy(gameObject);
            WaveSpawner.nrofEnemies--;
            PlayerStats.Health -= Damage;
            if(PlayerStats.Health <= 0)
            {
                GameOverMenu.Pause();
            }
            PlayerStats.HealthBar.SetHealth(PlayerStats.Health, PlayerStats.healthMax);
            Debug.Log(PlayerStats.Health);
        }
    }
}
