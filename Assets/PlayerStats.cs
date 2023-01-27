using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public static int healthMax;
    public static int Health;
    public int startHealth = 600;
    public int startMoney = 300;
    public static HealthBar HealthBar;
    public HealthBar healthBar;

    void Start()
    {
        Money = startMoney;
        Health = startHealth;
        healthMax = startHealth;
        HealthBar = healthBar;
        HealthBar.SetHealth(Health, startHealth);
    }
}
