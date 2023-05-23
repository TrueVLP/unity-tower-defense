using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildButtonScript : MonoBehaviour
{
    public GameObject Panzer;
    public GameObject Helikopter;
    public GameObject Schiff;
    public GameObject Truppenmen�;
    public void BuildClick()
    {
        if(Truppenmen�.GetComponent<Image>().enabled == false)
        {
            Truppenmen�.GetComponent<Image>().enabled = true;
            Panzer.GetComponent<Image>().enabled = true;
            Panzer.GetComponent<Button>().enabled = true;
            Helikopter.GetComponent<Image>().enabled = true;
            Helikopter.GetComponent<Button>().enabled = true;
            Schiff.GetComponent<Image>().enabled = true;
            Schiff.GetComponent<Button>().enabled = true;
            PlayerPrefs.SetInt("bauen", 1);
            
        }

        else
        {
            Truppenmen�.GetComponent<Image>().enabled = false;
            Panzer.GetComponent<Image>().enabled = false;
            Panzer.GetComponent<Button>().enabled = false;
            Helikopter.GetComponent<Image>().enabled = false;
            Helikopter.GetComponent<Button>().enabled = false;
            Schiff.GetComponent<Image>().enabled = false;
            Schiff.GetComponent<Button>().enabled = false;
            PlayerPrefs.SetInt("bauen", 0);

        }
        


    }

}
