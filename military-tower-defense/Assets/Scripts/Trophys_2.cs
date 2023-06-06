using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trophys_2 : MonoBehaviour
{
    //Text zum aktualisieren für den Text
    public TextMeshProUGUI Trophys;

    //aktualisiert den Text
    void Start()
    {
        if (PlayerPrefs.HasKey("trophyRecord"))
        {
            Trophys.text = " " + PlayerPrefs.GetInt("trophyRecord");
        }
        else
        {
            Trophys.text = "0";
        }
        
    }
}
