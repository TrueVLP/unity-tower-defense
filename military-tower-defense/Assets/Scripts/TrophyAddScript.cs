using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TrophyAddScript : MonoBehaviour
{
    public TextMeshProUGUI Trophy1;
    public TextMeshProUGUI Trophy2;
    public GameObject Image2;
    public int TrophyCount;

    void Start()
    {
        Trophy2.text = "";
        Image2.GetComponent<UnityEngine.UI.Image>().enabled = false;

        Trophy1.text = "" + PlayerPrefs.GetInt("trophy");

        StartCoroutine(ShowAfterDelay(0.5f));

        StartCoroutine(RemoveAfterDelay(3f));

        StartCoroutine(ChangeTrophy(2f));

    }

    IEnumerator ShowAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Trophy2.text = "+ 30";
        Image2.GetComponent<UnityEngine.UI.Image>().enabled = true;
    }

    IEnumerator RemoveAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Trophy2.text = "";
        Image2.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }

    IEnumerator ChangeTrophy(float delay)
    {
        yield return new WaitForSeconds(delay);

        TrophyCount = PlayerPrefs.GetInt("trophy") + 30;

        PlayerPrefs.SetInt("trophy", TrophyCount);

        Trophy1.text = "" + TrophyCount;

    }
}
