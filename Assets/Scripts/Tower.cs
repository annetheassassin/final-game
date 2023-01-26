using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject ProjectilesPrefab;

    private GameObject projectile = null;

    private int AttackCooldown = 0;

    private SpriteRenderer mySpriteRenderer;

    private Monster targetTower;

    private Monster targetProjectile;

    [SerializeField]
    public float projectileSpeed;

    private List<Monster> monstersList = new List<Monster>();

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Attack();
    }

    //Select the tower and show radius
    public void Select()
    {
        mySpriteRenderer.enabled = !mySpriteRenderer.enabled;
    }

    //If Enemy enters radius, detect it
    //NEEDS TO ADD MONSTER SUPPORT ETC
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Monster")
        {
            monstersList.Add(other.GetComponent<Monster>());
        }
    }

    //If Enemy leaves radius, detect it
    //NEEDS TO ADD MONSTER SUPPORT ETC
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Monster")
        {
            monstersList.Remove(other.GetComponent<Monster>());
            if (monstersList.Count == 0)
            {
                targetTower = null;
                AttackCooldown = 0;
            }
        }
    }

    //Attack and face towards the monster

    public void Attack()
    {
        Vector2 MonsterPos;
        if (monstersList.Count > 0)
        {
            targetTower = monstersList[0];
        }
        if (targetTower != null)
        {
            MonsterPos = targetTower.transform.position;
            FaceEnemy(MonsterPos);
            bool isCanAttack = CanAttack();
            ShootEnemy(isCanAttack);
        }
        MoveToMonster();
    }

    public bool CanAttack()
    {
        if (AttackCooldown > 0)
        {
            AttackCooldown -= 1;
            return false;
        }
        else
        {
            AttackCooldown = 60;
            return true;
        }
    }

    public void ShootEnemy(bool isCanAttack)
    {
        if (isCanAttack)
        {
            projectile = Instantiate(ProjectilesPrefab, transform.position, Quaternion.identity);
            targetProjectile = targetTower;
        }
    }

    public void MoveToMonster()
    {
        if (projectile != null)
        {
            projectile.transform.position = Vector2.MoveTowards(projectile.transform.position, targetProjectile.transform.position, projectileSpeed);
        }
    }

    //Calculate the degrees the tower has to turn to face towwards the Monster
    public void FaceEnemy(Vector2 MonsterPos)
    {
        Quaternion TowerRot;
        double radians;
        double degrees;

        TowerRot = transform.rotation;
        //calc degrees
        float x = MonsterPos.x - transform.position.x;
        float y = MonsterPos.y - transform.position.y;

        //radians
        radians = Math.Atan2(y, x);
        //angle
        degrees = radians * (180 / Math.PI);

        TowerRot = Quaternion.Euler(0, 0, (float)degrees);

        transform.rotation = TowerRot;
    }
}
