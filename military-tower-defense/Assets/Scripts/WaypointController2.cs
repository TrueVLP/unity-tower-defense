using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaypointController2 : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints
    public float speed = 0f; // Speed of the GameObject
    public Button speedButton1; // The first button to control the speed
    public Button speedButton2; // The second button to control the speed

    private int currentWaypointIndex = 0; // Index of the current waypoint

    void Start()
    {
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



        // Find the buttons in the scene and assign them to the variables
        speedButton1 = GameObject.Find("SpeedButton1").GetComponent<Button>();
        speedButton2 = GameObject.Find("SpeedButton2").GetComponent<Button>();

        // Add listeners to the buttons to control the speed
        speedButton1.onClick.AddListener(SetSpeedToOne);
        speedButton2.onClick.AddListener(SetSpeedToThree);
    }

    void Update()
    {
        // Move the GameObject towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        // Check if the GameObject has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    void SetSpeedToOne()
    {
        speed = 1f;
    }

    void SetSpeedToThree()
    {
        speed = 3f;
    }
}
