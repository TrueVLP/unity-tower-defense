using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void auführen()
    {
        int played = PlayerPrefs.GetInt("PCounter");
        int counter = PlayerPrefs.GetInt("Counter");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PCounter", played);
        PlayerPrefs.SetInt("Counter", counter);

    }

    public void ausführenButton()
    {
        SceneManager.LoadScene(0);
    }
}
