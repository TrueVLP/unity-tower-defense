using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorScript : MonoBehaviour
{
    void Start()
    {
        int counter = PlayerPrefs.GetInt("Counter", 0);
        counter++;
        PlayerPrefs.SetInt("Counter", counter);
    }

}
