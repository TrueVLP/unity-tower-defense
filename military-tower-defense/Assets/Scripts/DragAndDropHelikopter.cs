using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropHelikopter : MonoBehaviour
{
    private bool inBuildMode = false;

    public GameObject ObjectToSpawn;

    public UnityEngine.UI.Image NotEnoughMoney;

    public void EnterBuildMode()
    {
        inBuildMode = true;

        PlayerPrefs.SetInt("bp", 1);

    }

    void Update()
    {
        if (inBuildMode && Input.GetMouseButtonDown(0))
        {
            int money = PlayerPrefs.GetInt("money");
            money = money - 200;
            if (money >= 0)
            {
                PlayerPrefs.SetInt("money", money);
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = 5;
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
                inBuildMode = false;
            }else
            {
                NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = true;
                StartCoroutine(Delay2(1f));
            }
            
        }

        PlayerPrefs.SetInt("bp", 0);
    }

    IEnumerator Delay2(float delay)
    {
        yield return new WaitForSeconds(delay);

        NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }
}
