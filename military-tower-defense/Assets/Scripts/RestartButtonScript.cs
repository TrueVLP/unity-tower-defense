using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void auführen()
    {

        PlayerPrefs.DeleteAll();

    }

    public void ausführenButton()
    {
        SceneManager.LoadScene(0);
    }
}
