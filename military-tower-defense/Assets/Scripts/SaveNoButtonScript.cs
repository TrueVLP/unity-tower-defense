using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveNoButtonScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject SaveNoButton;
    public GameObject SaveYesButton;

    public void SaveNoClick()
    {

        menu.GetComponent<Image>().enabled = false;
        SaveNoButton.GetComponent<Button>().enabled = false;
        SaveNoButton.GetComponent<Image>().enabled = false;
        SaveYesButton.GetComponent<Image>().enabled = false;
        SaveYesButton.GetComponent<Button>().enabled = false;

    }
}
