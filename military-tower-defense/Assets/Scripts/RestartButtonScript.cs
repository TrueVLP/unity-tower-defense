using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    public void auf�hren()
    {

        PlayerPrefs.DeleteAll();

    }

    public void ausf�hrenButton()
    {
        SceneManager.LoadScene(0);
    }
}
