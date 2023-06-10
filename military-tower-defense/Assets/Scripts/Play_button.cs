using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play_button : MonoBehaviour
{

    //Script zum wechseln in die Main Methode und zum speichern gewisser Statistiken
    public void PlayClick()
    {
        PlayerPrefs.SetInt("bauen", 0);

        SceneManager.LoadScene(6);
    }
}
