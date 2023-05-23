using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointController2grün : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints
    public int speed;
    public Hearts otherScript;

    private int currentWaypointIndex = 0; // Index of the current waypoint

    void Start()
    {
        speed = PlayerPrefs.GetInt("speed");
        waypoints[0] = GameObject.Find("Waypoint").transform;
        waypoints[1] = GameObject.Find("Waypoint (1)").transform;
        waypoints[2] = GameObject.Find("Waypoint (2)").transform;
        waypoints[3] = GameObject.Find("Waypoint (3)").transform;
        waypoints[4] = GameObject.Find("Waypoint (4)").transform;
        waypoints[5] = GameObject.Find("Waypoint (5)").transform;
        waypoints[6] = GameObject.Find("Waypoint (6)").transform;
        waypoints[7] = GameObject.Find("Waypoint (7)").transform;
        waypoints[8] = GameObject.Find("Waypoint (8)").transform;
        waypoints[9] = GameObject.Find("Waypoint (9)").transform;
        waypoints[10] = GameObject.Find("Waypoint (10)").transform;
        waypoints[11] = GameObject.Find("Waypoint (11)").transform;
        waypoints[12] = GameObject.Find("Waypoint (12)").transform;
        waypoints[13] = GameObject.Find("Waypoint (13)").transform;
        waypoints[14] = GameObject.Find("Waypoint (14)").transform;
        waypoints[15] = GameObject.Find("Waypoint (15)").transform;
    }

    void Update()
    {
        speed = PlayerPrefs.GetInt("speed");
        // Move the GameObject towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        // Check if the GameObject has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
