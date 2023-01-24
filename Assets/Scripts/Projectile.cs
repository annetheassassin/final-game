using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage;
    void Start()
    {
        //delete object after 5 seconds
        Destroy(gameObject, 5.0f);
    }

    //Destroy projectile on enter collision
    //public void OnTriggerEnter2D(Collider2D other)
    //{
    //if (other.tag == "Monster")
    //{
    //Destroy(gameObject);
    //}
    //}
}