using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    public int hearts;
    public TextMeshProUGUI heartText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("hearts"))
        {
            hearts = PlayerPrefs.GetInt("hearts");
        }
        else
        {
            hearts = 200;
            PlayerPrefs.SetInt("hearts", hearts);
        }
    }
    private void Update()
    {
        heartText.text = "" + PlayerPrefs.GetInt("hearts");

        if (PlayerPrefs.GetInt("hearts") < 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
