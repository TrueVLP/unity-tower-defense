using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trophys_2 : MonoBehaviour
{
    public TextMeshProUGUI Trophys;
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
