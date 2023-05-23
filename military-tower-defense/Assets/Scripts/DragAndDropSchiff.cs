using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropSchiff : MonoBehaviour
{
    private bool inBuildMode = false;

    private int Counter1 = 0;

    public GameObject ObjectToSpawn;


    void Start()
    {
        if (PlayerPrefs.HasKey("counter3"))
        {
            Counter1 = PlayerPrefs.GetInt("counter3");
        }
        else
        {
            Counter1 = 0;
            PlayerPrefs.SetInt("counter3", Counter1);
        }

    }

    public void EnterBuildMode()
    {
        inBuildMode = true;

    }

    void Update()
    {
        if (inBuildMode && Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("counter3") == 0)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 5;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
            inBuildMode = false;
            Counter1 = PlayerPrefs.GetInt("counter3");
            Counter1++;
            PlayerPrefs.SetInt("counter3", Counter1);
            int money = PlayerPrefs.GetInt("money");
            money = money - 200;
            PlayerPrefs.SetInt("money", money);
        }
    }
}
