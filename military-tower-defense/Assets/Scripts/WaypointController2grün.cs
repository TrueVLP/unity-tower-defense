using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointController2grün : MonoBehaviour
{
    //Objekte die zum fortbewegen eines bunten Ballons dienen
    public Transform[] waypoints;
    public int speed;
    public Hearts otherScript;

    private int currentWaypointIndex = 0;

    //Sucht sich alle Wegpunkte auf der Karte
    void Start()
    {
        speed = PlayerPrefs.GetInt("speed");
        GameObject[] waypointsObjects = GameObject.FindGameObjectsWithTag("waypoint");
        waypoints = new Transform[waypointsObjects.Length];
        System.Array.Sort(waypointsObjects, (a, b) => a.name.CompareTo(b.name));
        for (int i = 0; i < waypointsObjects.Length; i++)
        {
            waypoints[i] = waypointsObjects[i].transform;
        }
    }

    //bewegt sich von Wegpunkt zu Wegpunkt und zieht beim letzten Wegpunkt die definierten Herzen ab
    void Update()
    {
        speed = PlayerPrefs.GetInt("speed");
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }

        if (currentWaypointIndex == waypoints.Length - 1)
        {
            Destroy(gameObject);
            int hearts = PlayerPrefs.GetInt("hearts") - 3;
            PlayerPrefs.SetInt("hearts", hearts);
        }
    }
}
