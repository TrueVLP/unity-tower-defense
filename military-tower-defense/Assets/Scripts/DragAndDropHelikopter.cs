using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropHelikopter : MonoBehaviour
{
    private bool inBuildMode = false;

    public GameObject ObjectToSpawn;

    public GameObject ObjectToSpawn2;

    public GameObject ObjectToSpawn3;

    public UnityEngine.UI.Image NotEnoughMoney;

    public void EnterBuildMode()
    {
        inBuildMode = true;

        PlayerPrefs.SetInt("bp", 1);

    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (inBuildMode && Input.GetMouseButtonDown(0))
        {
            int money = PlayerPrefs.GetInt("money");
            money = money - 200;
            if (money >= 0)
            {
                PlayerPrefs.SetInt("money", money);
                mousePos.z = 5;
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

                if (PlayerPrefs.GetInt("h") == 0)
                {
                    Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
                }

                if (PlayerPrefs.GetInt("h") == 1)
                {
                    Instantiate(ObjectToSpawn2, worldPos, Quaternion.identity);
                }
                if (PlayerPrefs.GetInt("h") == 2)
                {
                    Instantiate(ObjectToSpawn3, worldPos, Quaternion.identity);
                }
                inBuildMode = false;
            }
            else
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
