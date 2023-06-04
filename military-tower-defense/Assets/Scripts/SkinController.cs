using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinController : MonoBehaviour
{
    public Button PanzerSkin1;

    public TextMeshProUGUI PanzerSkin1T;

    public Image PanzerSkin1I;

    void Start()
    {

        if (PlayerPrefs.GetInt("trophyRecord") >= 400)
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

    }
}
