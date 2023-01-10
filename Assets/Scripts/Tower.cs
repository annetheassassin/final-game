using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private string projectTileType;

    private SpriteRenderer mySpriteRenderer;

    private Monster target;

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
        if(monstersList[0] != null)
        {
            Debug.Log(monstersList[0]);
        }

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
                target = null;
            }
        }
    }

    //Attack and face towards the monster
    public void Attack()
    {
        Vector2 MonsterPos;
        if (monstersList.Count > 0)
        {
            target = monstersList[0];
        }
        if (target != null)
        {
            MonsterPos = target.transform.position;
            FaceEnemy(MonsterPos);
            ShootEnemy();
        }
    }

    public void ShootEnemy()
    {

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
        degrees = radians * (180/Math.PI);

        TowerRot = Quaternion.Euler(0, 0, (float)degrees);

        transform.rotation = TowerRot;
    }

}