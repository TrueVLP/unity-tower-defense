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
        int won = PlayerPrefs.GetInt("won");
        int lose = PlayerPrefs.GetInt("lose");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PCounter", played);
        PlayerPrefs.SetInt("Counter", counter);
        PlayerPrefs.SetInt("won", won);
        PlayerPrefs.SetInt("lose", lose);

    }

    public void ausführenButton()
    {
        SceneManager.LoadScene(0);
    }
}
