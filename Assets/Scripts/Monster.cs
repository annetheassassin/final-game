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

    void FixedUpdate()
    {
        //tempPos = transform.position;

        //if (Input.GetKey(KeyCode.W)) { tempPos.y += 0.05f; }
        //if (Input.GetKey(KeyCode.S)) { tempPos.y -= 0.05f; }
        //if (Input.GetKey(KeyCode.D)) { tempPos.x += 0.05f; }
        //if (Input.GetKey(KeyCode.A)) { tempPos.x -= 0.05f; }


        //transform.position = tempPos;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            Debug.Log(health);
            Projectile projectile = other.GetComponent<Projectile>();
            health -= projectile.damage;
            HealthBar.SetHealth(health, MaxHealth);
            Debug.Log(health);
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
                WaveSpawner.nrofEnemies--;
            }
        }
    }
}
