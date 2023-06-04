using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trophys : MonoBehaviour
{
    public TextMeshProUGUI Trophy1;
    
    void Start()
    {
        Trophy1.text = "" + PlayerPrefs.GetInt("trophy");
    }
}
