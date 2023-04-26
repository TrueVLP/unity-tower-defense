using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public float speed = 1.0f; // Geschwindigkeit des Flugs
    public float destroyTime = 5.0f; // Zeit bis zur Zerst�rung des GameObjects

    void Start()
    {
        // Zerst�rt das GameObject nach der angegebenen Zeit
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        // Bewegt das GameObject in jedem Frame nach oben
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnMouseDown()
    {
        // Zerst�rt das angeklickte GameObject
        Destroy(gameObject);
    }
}
