using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtonScript : MonoBehaviour
{
    public void auf�hren()
    {
        int money = PlayerPrefs.GetInt("money");
        money = money - 200;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("ability3", 10);
    }
}
