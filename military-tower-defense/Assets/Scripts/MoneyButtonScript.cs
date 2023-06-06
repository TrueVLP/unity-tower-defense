using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyButtonScript : MonoBehaviour
{

    public UnityEngine.UI.Image NotEnoughMoney;

    public void ausführen()
    {
        int money = PlayerPrefs.GetInt("money");
        money = money - 200;
        if (PlayerPrefs.GetInt("ability2") == 1|| money < 0)
        {
            NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = true;
            StartCoroutine(Delay2(1f));
        }
        else
        {
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("ability2", 1);
        }
    }

    IEnumerator Delay2(float delay)
    {
        yield return new WaitForSeconds(delay);

        NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }
}
