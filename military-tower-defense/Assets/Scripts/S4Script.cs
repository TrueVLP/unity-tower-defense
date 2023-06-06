using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S4Script : MonoBehaviour
{

    //Script zun setzn der Losing Statistic in der Statistic Szene
    public TextMeshProUGUI LoseText;

    private void Start()
    {
        int counter = PlayerPrefs.GetInt("lose", 0);
        LoseText.text = "" + counter;
    }
}
