using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    int won;


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
