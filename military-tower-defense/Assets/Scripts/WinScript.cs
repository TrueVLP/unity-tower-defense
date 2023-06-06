using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    //Variable zum speichern der Anzahl der Siege
    int won;

    //Diese Methode holt sich gegebenenfalls eine gespeicherte won-zahl und speichert die neue won-zahl im Playerprefab
    void Start()
    {

        if (PlayerPrefs.HasKey("won"))
        {
            won = PlayerPrefs.GetInt("won");
        }
        else
        {
            PlayerPrefs.SetInt("won", 0);
            won = 0;
        }

        won = won + 1;

        PlayerPrefs.SetInt("won", won);

    }
}
