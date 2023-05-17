using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S1Script : MonoBehaviour
{
    public TextMeshProUGUI startedText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        startedText.text = "" + counter + "x";
    }
}
