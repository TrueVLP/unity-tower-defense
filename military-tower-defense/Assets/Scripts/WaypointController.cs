using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 0f;
    public List<GameObject> objectsToMove;

    private int currentWaypointIndex = 0;

    void Start()
    {
        objectsToMove = new List<GameObject>(GameObject.FindGameObjectsWithTag("Bloon"));
    }

    void Update()
    {
        foreach (GameObject obj in objectsToMove)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

            if (Vector3.Distance(obj.transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {

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
