using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float speed;
    private Waypoints Wpoints;

    private int waypointIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

    Vector3 direction = Wpoints.waypoints[waypointIndex].position - transform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f) {
    
        if(waypointIndex < Wpoints.waypoints.Length - 1) {
           waypointIndex++;
           } else {
             Destroy(gameObject);
             }
        }

      }

    }
