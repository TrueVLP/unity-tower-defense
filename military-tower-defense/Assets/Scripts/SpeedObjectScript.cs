using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedObjectScript : MonoBehaviour
{
    public int speed;

    void Start()
    {

        if (PlayerPrefs.HasKey("speed"))
        {
            speed = PlayerPrefs.GetInt("speed");
        }
        else
        {
            speed = 0;
            PlayerPrefs.SetInt("speed", speed);
        }

    }

    public void Speedbutton1()
    {
        PlayerPrefs.SetInt("speed", 3);
    }

    public void Speedbutton2()
    {
        PlayerPrefs.SetInt("speed", 1);
    }
}
