using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints
    public float speed = 0f; // Speed of the GameObjects
    public List<GameObject> objectsToMove; // List of GameObjects to move

    private int currentWaypointIndex = 0; // Index of the current waypoint

    void Start()
    {
        objectsToMove = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bloon"));
    }

    void Update()
    {
        // Move each GameObject towards the current waypoint
        foreach (GameObject obj in objectsToMove)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

            // Check if the GameObject has reached the current waypoint
            if (Vector3.Distance(obj.transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {
                // Move to the next waypoint
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
        }
    }

    public void SetSpeedToOne()
    {
        speed = 1f;
    }

    public void SetSpeedToThree()
    {
        speed = 3f;
    }

}
