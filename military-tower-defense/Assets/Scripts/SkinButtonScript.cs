using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinButtonScript : MonoBehaviour
{
    //Wechselt in die Skin Szene
    public void SkinClick()
    {
        SceneManager.LoadScene(5);
    }
}
