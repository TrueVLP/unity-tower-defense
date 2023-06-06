using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinController : MonoBehaviour
{
    public Button PanzerSkin1;

    public TextMeshProUGUI PanzerSkin1T;

    public Image PanzerSkin1I;

    public Button HeliSkin1;

    public TextMeshProUGUI HeliSkin1T;

    public Image HeliSkin1I;

    public Button HeliSkin2;

    public TextMeshProUGUI HeliSkin2T;

    public Image HeliSkin2I;

    public Button SchiffSkin1;

    public TextMeshProUGUI SchiffSkin1T;

    public Image SchiffSkin1I;

    void Start()
    {
        
        if (PlayerPrefs.GetInt("trophyRecord") >= 400 || PlayerPrefs.GetInt("trophy") >= 400)
        {
            PanzerSkin1.GetComponent<Button>().enabled = true;

            PanzerSkin1I.GetComponent<Image>().enabled = false;

            PanzerSkin1T.gameObject.SetActive(false); ;
        }
        else
        {
            PanzerSkin1.GetComponent<Button>().enabled = false;

            PanzerSkin1I.GetComponent<Image>().enabled = true;

            PanzerSkin1T.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("trophyRecord") >= 600 || PlayerPrefs.GetInt("trophy") >= 600)
        {
            HeliSkin1.GetComponent<Button>().enabled = true;

            HeliSkin1I.GetComponent<Image>().enabled = false;

            HeliSkin1T.gameObject.SetActive(false); ;
        }
        else
        {
            HeliSkin1.GetComponent<Button>().enabled = false;

            HeliSkin1I.GetComponent<Image>().enabled = true;

            HeliSkin1T.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("trophyRecord") >= 1000 || PlayerPrefs.GetInt("trophy") >= 1000)
        {
            HeliSkin2.GetComponent<Button>().enabled = true;

            HeliSkin2I.GetComponent<Image>().enabled = false;

            HeliSkin2T.gameObject.SetActive(false); ;
        }
        else
        {
            HeliSkin2.GetComponent<Button>().enabled = false;

            HeliSkin2I.GetComponent<Image>().enabled = true;

            HeliSkin2T.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("trophyRecord") >= 800 || PlayerPrefs.GetInt("trophy") >= 800)
        {
            SchiffSkin1.GetComponent<Button>().enabled = true;

            SchiffSkin1I.GetComponent<Image>().enabled = false;

            SchiffSkin1T.gameObject.SetActive(false); ;
        }
        else
        {
            SchiffSkin1.GetComponent<Button>().enabled = false;

            SchiffSkin1I.GetComponent<Image>().enabled = true;

            SchiffSkin1T.gameObject.SetActive(true);
        }

    }

    public void Skin1Click()
    {
        PlayerPrefs.SetInt("p", 0);
    }

    public void Skin2Click()
    {
        PlayerPrefs.SetInt("p", 1);
    }
    public void Skin3Click()
    {
        PlayerPrefs.SetInt("h", 0);
    }
    public void Skin4Click()
    {
        PlayerPrefs.SetInt("h", 1);
    }
    public void Skin5Click()
    {
        PlayerPrefs.SetInt("s", 0);
    }
    public void Skin6Click()
    {
        PlayerPrefs.SetInt("s", 1);
    }

    public void Skin7Click()
    {
        PlayerPrefs.SetInt("h", 2);
    }
}
