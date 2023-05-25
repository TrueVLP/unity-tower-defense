using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void auf�hren()
    {
        int played = PlayerPrefs.GetInt("PCounter");
        int counter = PlayerPrefs.GetInt("Counter");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PCounter", played);
        PlayerPrefs.SetInt("Counter", counter);

    }

    public void ausf�hrenButton()
    {
        SceneManager.LoadScene(0);
    }
}
