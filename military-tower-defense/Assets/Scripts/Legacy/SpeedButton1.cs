using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedButton1 : MonoBehaviour
{
    public GameObject otherObject;

    public float speed;

    void Start()
    {
        WaypointController otherScript = otherObject.GetComponent<WaypointController>();

        speed = otherScript.speed;
    }
    void OnMouseDown()
    {
        speed = 1;
    }
}