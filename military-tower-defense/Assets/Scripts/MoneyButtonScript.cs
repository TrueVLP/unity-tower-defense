using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyButtonScript : MonoBehaviour
{
    public void ausf�hren()
    {
        int money = PlayerPrefs.GetInt("money");
        money = money - 200;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("ability2", 1);
    }
}
