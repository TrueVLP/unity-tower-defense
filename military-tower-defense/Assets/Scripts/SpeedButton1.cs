using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedButton1 : MonoBehaviour
{
    public GameObject otherObject; // The GameObject with the OtherScript attached

    public float speed;

    void Start()
    {
        // Get a reference to the OtherScript component on the otherObject
        WaypointController otherScript = otherObject.GetComponent<WaypointController>();

        // Access the myVariable variable of the OtherScript
        speed = otherScript.speed;
    }
    void OnMouseDown()
    {
        speed = 1;
    }
}