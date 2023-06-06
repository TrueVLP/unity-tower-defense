using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveYesButtonScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject SaveNoButton;
    public GameObject SaveYesButton;

    public void SaveYesClick()
    {

        menu.GetComponent<Image>().enabled = false;
        SaveNoButton.GetComponent<Button>().enabled = false;
        SaveNoButton.GetComponent<Image>().enabled = false;
        SaveYesButton.GetComponent<Image>().enabled = false;
        SaveYesButton.GetComponent<Button>().enabled = false;

    }
}
