using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartButtonScript : MonoBehaviour
{
    //Script zum bedienen der Herz Fähigkeit
    public MoneyScript moneyScript;

    public Hearts heartScript;

    public UnityEngine.UI.Image NotEnoughMoney;

    public void ausführen()
    {

        int money = PlayerPrefs.GetInt("money");

        money = money - 200;

        if (money < 0)
        {
            NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = true;
            StartCoroutine(Delay2(1f));
        }
        else
        {
            PlayerPrefs.SetInt("money", money);
            int hearts = PlayerPrefs.GetInt("hearts");

            hearts = hearts + 10;

            PlayerPrefs.SetInt("hearts", hearts);
        }
    }

    IEnumerator Delay2(float delay)
    {
        yield return new WaitForSeconds(delay);

        NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }    
}
