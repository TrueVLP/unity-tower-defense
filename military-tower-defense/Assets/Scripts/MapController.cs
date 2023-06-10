using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{

    public int MapCounter;

    public int MapCounter2;

    public int BackCounter;

    public GameObject MapButton1;

    public GameObject MapButton2;

    public GameObject MapButton3;

    public GameObject PfeilButtonLinks;

    public GameObject PfeilButtonRechts;

    public GameObject LoadButton;

    public GameObject NewGameButton;

    public GameObject NewGameButton2;
    
    void Start()
    {
        MapCounter = 0;

        BackCounter = 0;

        LoadButton.SetActive(true);

        MapButton1.SetActive(false);

        MapButton2.SetActive(false);

        MapButton3.SetActive(false);

        PfeilButtonLinks.SetActive(false);

        PfeilButtonRechts.SetActive(false);

        if (PlayerPrefs.HasKey("map"))
        {
            NewGameButton.SetActive(true);
        }
        else
        {
            NewGameButton2.SetActive(true);

            LoadButton.SetActive(false);
        }
    }
    void Update()
    {
        if (MapCounter == 1)
        {
            MapButton1.SetActive(true);
            MapButton2.SetActive(false);
            MapButton3.SetActive(false);
        }
        else if (MapCounter == 2)
        {
            MapButton1.SetActive(false);
            MapButton2.SetActive(true);
            MapButton3.SetActive(false);
        }
        else if (MapCounter == 3)
        {
            MapButton1.SetActive(false);
            MapButton2.SetActive(false);
            MapButton3.SetActive(true);
        }
        else
        {
            MapButton1.SetActive(false);
            MapButton2.SetActive(false);
            MapButton3.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.A) && MapCounter >= 1 && MapCounter <= 3)
        {
            PfeilLinkClick();
        }

        if (Input.GetKeyDown(KeyCode.D) && MapCounter >= 1 && MapCounter <= 3)
        {
            PfeilRechtsClick();
        }
    }

    public void PfeilLinkClick()
    { 

        MapCounter2 = MapCounter - 1;

        if (MapCounter2 > 0)
        {
            MapCounter = MapCounter - 1;
        }
        else
        {
            MapCounter = 3;
        }
    }

    public void PfeilRechtsClick()
    {
        
        MapCounter2 = MapCounter + 1;

        if (MapCounter2 < 4)
        {
            MapCounter = MapCounter + 1;
        }
        else
        {
            MapCounter = 1;
        }
    }

    public void Map1Click()
    {
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        counter = counter + 1;
        PlayerPrefs.SetInt("PCounter", counter);

        PlayerPrefs.SetInt("map", 1);
        SceneManager.LoadScene(1);
    }

    public void Map2Click()
    {
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        counter = counter + 1;
        PlayerPrefs.SetInt("PCounter", counter);

        PlayerPrefs.SetInt("map", 7);
        SceneManager.LoadScene(7);
    }

    public void Map3Click()
    {
        int counter = PlayerPrefs.GetInt("PCounter", 0);
        counter = counter + 1;
        PlayerPrefs.SetInt("PCounter", counter);

        PlayerPrefs.SetInt("map", 8);
        SceneManager.LoadScene(8);
    }

    public void ResetClick()
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

        LoadButton.SetActive(false);

        MapButton1.SetActive(true);

        MapButton2.SetActive(true);

        MapButton3.SetActive(true);

        PfeilButtonLinks.SetActive(true);

        PfeilButtonRechts.SetActive(true);

        MapCounter = 1;

        BackCounter = 1;

        NewGameButton.SetActive(false);

        NewGameButton2.SetActive(false);
    }

    public void LoadClick()
    {

        int counter = PlayerPrefs.GetInt("PCounter", 0);
        counter = counter + 1;
        PlayerPrefs.SetInt("PCounter", counter);

        SceneManager.LoadScene(PlayerPrefs.GetInt("map", 1));
    }

    public void BackClick()
    {
        if (BackCounter == 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            LoadButton.SetActive(true);

            MapButton1.SetActive(false);

            MapButton2.SetActive(false);

            MapButton3.SetActive(false);

            PfeilButtonLinks.SetActive(false);

            PfeilButtonRechts.SetActive(false);

            MapCounter = 0;

            BackCounter = 0;

            if (PlayerPrefs.HasKey("map"))
            {
                NewGameButton.SetActive(true);
            }
            else
            {
                NewGameButton2.SetActive(true);
                LoadButton.SetActive(false);
            }
        }
    }
}
