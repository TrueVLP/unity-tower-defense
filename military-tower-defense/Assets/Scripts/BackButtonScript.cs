using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    //Script zum Bedienen des Back Buttons
    public void BackClick()
    {
        
        SceneManager.LoadScene(0);

    }
}
