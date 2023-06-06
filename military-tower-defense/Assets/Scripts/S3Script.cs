using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S3Script : MonoBehaviour
{

    //Script zun setzn der win Statistic in der Statistic Szene
    public TextMeshProUGUI startedText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("won", 0);
        startedText.text = "" + counter;
    }
}
