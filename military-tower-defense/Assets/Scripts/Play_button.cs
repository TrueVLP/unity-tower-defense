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
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        counter = counter + 1;
        PlayerPrefs.SetInt("PCounter", counter);
        SceneManager.LoadScene(1);

        PlayerPrefs.SetInt("bauen", 0);
    }
}
