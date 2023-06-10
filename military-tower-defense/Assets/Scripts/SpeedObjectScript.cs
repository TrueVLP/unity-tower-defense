using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedObjectScript : MonoBehaviour
{
    //speed variable zum Zwischenspeichern
    public int speed;


    //holt sich, wenn vorhanden das Speed aus dem Playerprefab
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

    //Überprüft ob gerade gebaut wird
    void Update()
    {
        if (PlayerPrefs.GetInt("bp") == 1)
        {
            PlayerPrefs.SetInt("speed", 0);
        }
    }

    //Setzt das speed auf 3
    public void Speedbutton1()
    {
        PlayerPrefs.SetInt("speed", 4);
    }

    //Setzt das speed auf 1
    public void Speedbutton2()
    {
        PlayerPrefs.SetInt("speed", 2);
    }
}
