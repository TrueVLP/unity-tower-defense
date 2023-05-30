using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S4Script : MonoBehaviour
{
    public TextMeshProUGUI LoseText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("lose", 0);
        LoseText.text = "" + counter;
    }
}
