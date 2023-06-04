using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void auführen()
    {
        int played = PlayerPrefs.GetInt("PCounter");
        int won = PlayerPrefs.GetInt("won");
        int lose = PlayerPrefs.GetInt("lose");
        int trophy = PlayerPrefs.GetInt("trophy");
        int trophyRecord = PlayerPrefs.GetInt("trophyRecord");
        string name = PlayerPrefs.GetString("name");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PCounter", played);
        PlayerPrefs.SetInt("won", won);
        PlayerPrefs.SetInt("lose", lose);
        PlayerPrefs.SetInt("trophy", trophy);
        PlayerPrefs.SetInt("trophyRecord", trophyRecord);
        PlayerPrefs.SetString("name", name);

    }

    public void ausführenButton()
    {
        SceneManager.LoadScene(0);
    }
}
