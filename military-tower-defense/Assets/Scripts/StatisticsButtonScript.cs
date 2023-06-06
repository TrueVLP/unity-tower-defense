using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatisticsButtonScript : MonoBehaviour
{

    //Wechselt die Szene zu den Statistiken
    public void StatisticsClick()
    {
        SceneManager.LoadScene(2);
    }
}
