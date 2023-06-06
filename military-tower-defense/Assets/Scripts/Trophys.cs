using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trophys : MonoBehaviour
{
    //Text zum aktualisieren
    public TextMeshProUGUI Trophy1;
    
    //aktualisiert den Text
    void Start()
    {
        Trophy1.text = "" + PlayerPrefs.GetInt("trophy");
    }
}
