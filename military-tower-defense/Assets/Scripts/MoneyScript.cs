using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{

    public TextMeshProUGUI moneyText;

    public int money = 500;

    private void Update()
    {
        moneyText.text = "" + money;
    }
}
