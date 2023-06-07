using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{

    //DIENT AUSSCHLIESSlich ZUM TESTEN!!!
    public void test1Click()
    {
        PlayerPrefs.SetInt("trophy", 400);
        PlayerPrefs.SetInt("trophyRecord", 400);
    }

    public void test2Click()
    {
        PlayerPrefs.SetInt("trophy", 600);
        PlayerPrefs.SetInt("trophyRecord", 600); 
    }

    public void test3Click()
    {
        PlayerPrefs.SetInt("trophy", 800);
        PlayerPrefs.SetInt("trophyRecord", 800);
    }

    public void test4Click()
    {
        PlayerPrefs.SetInt("trophy", 1000);
        PlayerPrefs.SetInt("trophyRecord", 1000);
    }

    public void test5Click()
    {
        PlayerPrefs.SetInt("trophy", 0);
        PlayerPrefs.SetInt("trophyRecord", 0);
    }
}
