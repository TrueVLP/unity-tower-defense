using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S1Script : MonoBehaviour
{

    //Script zun setzn der Play Statistic in der Statistic Szene
    public TextMeshProUGUI startedText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        startedText.text = "" + counter + "x";
    }
}
