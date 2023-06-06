using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public void test1Click()
    {
        PlayerPrefs.SetInt("trophy", 400);
    }

    public void test2Click()
    {
        PlayerPrefs.SetInt("trophy", 600);
    }

    public void test3Click()
    {
        PlayerPrefs.SetInt("trophy", 800);
    }

    public void test4Click()
    {
        PlayerPrefs.SetInt("trophy", 1000);
    }

    public void test5Click()
    {
        PlayerPrefs.SetInt("trophy", 0);
    }
}
