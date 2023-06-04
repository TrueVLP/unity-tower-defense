using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S2Script : MonoBehaviour
{
    public TextMeshProUGUI S2;

    int trophyRecord;

    private void Start()
    {
        int trophy = PlayerPrefs.GetInt("trophy");

        if(PlayerPrefs.HasKey("trophyRecord"))
        {
            trophyRecord = PlayerPrefs.GetInt("trophyRecord");
        }
        else
        {
            PlayerPrefs.SetInt("trophyRecord", 0);
            trophyRecord = PlayerPrefs.GetInt("trophyRecord");
        }

        if(trophy >= trophyRecord)
        {
            PlayerPrefs.SetInt("trophyRecord", trophy);
        }

        S2.text = "" + PlayerPrefs.GetInt("trophyRecord");
    }
}
