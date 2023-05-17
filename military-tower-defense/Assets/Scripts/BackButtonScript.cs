using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    public void BackClick()
    {

        int counter = PlayerPrefs.GetInt("Counter", 0);
        counter = counter - 1;
        PlayerPrefs.SetInt("Counter", counter);

        SceneManager.LoadScene(0);

    }
}
