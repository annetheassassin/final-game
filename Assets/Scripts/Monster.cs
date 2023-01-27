using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    public float MaxHealth;

    private float health;

    public int CoinsOnDeath;

    public HealthBar HealthBar;

    private bool alive = true;

    public static string TAG
    {
        get;
        internal set;
    }

    static Vector2 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
        HealthBar.SetHealth(health, MaxHealth);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            if(health > 0)
            {
                Debug.Log(health);
                Projectile projectile = other.GetComponent<Projectile>();
                health -= projectile.Tower.Damage;
                HealthBar.SetHealth(health, MaxHealth);
                Debug.Log(health);
                Destroy(other.gameObject);
            }
            if (health <= 0 && alive)
            {
                alive = false;
                gameObject.GetComponentInChildren<BoxCollider2D>().isTrigger = false;
                PlayerStats.Money += CoinsOnDeath;
                WaveSpawner.nrofEnemies--;
                Destroy(gameObject);
            }
        }
    }
}
