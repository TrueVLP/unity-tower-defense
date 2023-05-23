using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundCounterScript : MonoBehaviour
{
    public int RoundCounter;
    public TextMeshProUGUI RoundsText;

    void Start()
    {

        if (PlayerPrefs.HasKey("rounds"))
        {
            RoundCounter = PlayerPrefs.GetInt("rounds");
        }
        else
        {
            RoundCounter = 0;
            PlayerPrefs.SetInt("rounds", RoundCounter);
        }

    }

    private void Update()
    {
        RoundsText.text = "" + PlayerPrefs.GetInt("rounds");
    }
}
