using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveButtonScript : MonoBehaviour
{
    public GameObject menue;
    public GameObject button1;
    public GameObject button2;

    public void SaveClick()
    {
        if (menue.GetComponent<Image>().enabled == false)
        {
            menue.GetComponent<Image>().enabled = true;
            button1.GetComponent<Image>().enabled = true;
            button2.GetComponent<Image>().enabled = true;
            button1.GetComponent<Button>().enabled = true;
            button2.GetComponent<Button>().enabled = true;
        }

        else
        {
            menue.GetComponent<Image>().enabled = false;
            button1.GetComponent<Image>().enabled = false;
            button2.GetComponent<Image>().enabled = false;
            button1.GetComponent<Button>().enabled = false;
            button2.GetComponent<Button>().enabled = false;
        }
    }
}
