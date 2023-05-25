using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartButtonScript : MonoBehaviour
{
    public MoneyScript moneyScript;

    public Hearts heartScript;

    public void ausführen()
    {

        int money = PlayerPrefs.GetInt("money");

        money = money - 200;

        PlayerPrefs.SetInt("money", money);

        int hearts = PlayerPrefs.GetInt("hearts");

        hearts = hearts + 10;

        PlayerPrefs.SetInt("hearts", hearts);
    }
}
