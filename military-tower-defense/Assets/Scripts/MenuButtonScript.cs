using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonScript : MonoBehaviour
{
    public GameObject Homebutton;
    public GameObject SaveButton;
    public GameObject RestartButton;
    public GameObject SpeedButton1;
    public GameObject SpeedButton2;
    public GameObject BuildButton;
    public GameObject HeartButton;
    public GameObject MoneyButton;
    public GameObject ArrowButton;

    public void MenuClick()
    {
        if (Homebutton.GetComponent<Image>().enabled == false)
        {
            Homebutton.GetComponent<Image>().enabled = true;
            SaveButton.GetComponent<Image>().enabled = true;
            RestartButton.GetComponent<Image>().enabled = true;
            SpeedButton1.GetComponent<Image>().enabled = true;
            SpeedButton2.GetComponent<Image>().enabled = true;
            BuildButton.GetComponent<Image>().enabled = true;
            HeartButton.GetComponent<Image>().enabled = true;
            MoneyButton.GetComponent<Image>().enabled = true;
            ArrowButton.GetComponent<Image>().enabled = true;
            Homebutton.GetComponent<Button>().enabled = true;
            SaveButton.GetComponent<Button>().enabled = true;
            RestartButton.GetComponent<Button>().enabled = true;
            SpeedButton1.GetComponent<Button>().enabled = true;
            SpeedButton2.GetComponent<Button>().enabled = true;
            BuildButton.GetComponent<Button>().enabled = true;
            HeartButton.GetComponent<Button>().enabled = true;
            MoneyButton.GetComponent<Button>().enabled = true;
            ArrowButton.GetComponent<Button>().enabled = true;

        }

        else
        {
            Homebutton.GetComponent<Image>().enabled = false;
            SaveButton.GetComponent<Image>().enabled = false;
            RestartButton.GetComponent<Image>().enabled = false;
            SpeedButton1.GetComponent<Image>().enabled = false;
            SpeedButton2.GetComponent<Image>().enabled = false;
            BuildButton.GetComponent<Image>().enabled = false;
            HeartButton.GetComponent<Image>().enabled = false;
            MoneyButton.GetComponent<Image>().enabled = false;
            ArrowButton.GetComponent<Image>().enabled = false;
            Homebutton.GetComponent<Button>().enabled = false;
            SaveButton.GetComponent<Button>().enabled = false;
            RestartButton.GetComponent<Button>().enabled = false;
            SpeedButton1.GetComponent<Button>().enabled = false;
            SpeedButton2.GetComponent<Button>().enabled = false;
            BuildButton.GetComponent<Button>().enabled = false;
            HeartButton.GetComponent <Button>().enabled = false;
            MoneyButton.GetComponent <Button>().enabled = false;
            ArrowButton.GetComponent <Button>().enabled = false;
        }
    }
}
