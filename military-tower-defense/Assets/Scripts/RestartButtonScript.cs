using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{

    //Script zun löschen aller gespeicherten Werte bis auf esenzielle Werte und wechselt gegebenenfalls auch zurück zum Hauptmenü
    public void auführen()
    {
        int played = PlayerPrefs.GetInt("PCounter");
        int won = PlayerPrefs.GetInt("won");
        int lose = PlayerPrefs.GetInt("lose");
        int trophy = PlayerPrefs.GetInt("trophy");
        int trophyRecord = PlayerPrefs.GetInt("trophyRecord");
        string name = PlayerPrefs.GetString("name");
        int p = PlayerPrefs.GetInt("p");
        int h = PlayerPrefs.GetInt("h");
        int s = PlayerPrefs.GetInt("s");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PCounter", played);
        PlayerPrefs.SetInt("won", won);
        PlayerPrefs.SetInt("lose", lose);
        PlayerPrefs.SetInt("trophy", trophy);
        PlayerPrefs.SetInt("trophyRecord", trophyRecord);
        PlayerPrefs.SetString("name", name);
        PlayerPrefs.SetInt("p", p);
        PlayerPrefs.SetInt("h", h);
        PlayerPrefs.SetInt("s", s);

    }

    public void ausführenButton()
    {
        SceneManager.LoadScene(0);
    }
}
