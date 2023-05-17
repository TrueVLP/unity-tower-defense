using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S2Script : MonoBehaviour
{
    public TextMeshProUGUI playedText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("Counter", 0);
        playedText.text = "" + counter + "x";
    }
}
