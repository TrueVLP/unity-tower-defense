using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonScript : MonoBehaviour
{
    //Script zum wechseln in die MainMenu Szene
    public void HomeClick()
    {
        SceneManager.LoadScene(0);
    }
}
