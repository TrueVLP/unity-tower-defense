using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyScript : MonoBehaviour
{

    public TextMeshProUGUI moneyText;

    public int money;

    private void Start()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetInt("money");
        }
        else
        {
            money = 200;
            PlayerPrefs.SetInt("money", money);
        }
    }
    

    private void Update()
    {
        moneyText.text = "" + PlayerPrefs.GetInt("money");

        if (PlayerPrefs.GetInt("money") < 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
