using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    //Script zum handeling der verlorenen Kämpfe
    int lose;

    void Start()
    {
        if (PlayerPrefs.HasKey("lose"))
        {
            lose = PlayerPrefs.GetInt("lose");
        }
        else
        {
            PlayerPrefs.SetInt("lose", 0);
            lose = 0;
        }

        lose = lose + 1;

        PlayerPrefs.SetInt("lose", lose);
    }

}
