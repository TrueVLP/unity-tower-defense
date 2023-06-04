using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinButtonScript : MonoBehaviour
{
    public void SkinClick()
    {
        SceneManager.LoadScene(5);
    }
}
