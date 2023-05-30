using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S3Script : MonoBehaviour
{
    public TextMeshProUGUI startedText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("won", 0);
        startedText.text = "" + counter;
    }
}
