using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

public class DragAndDropPanzer : MonoBehaviour
{
    private bool inBuildMode = false;

    private int Counter1 = 0; 

    public GameObject ObjectToSpawn;

    public GameObject Badget0;

    public GameObject Badget1;

    public GameObject Badget2;

    public GameObject Badget3;

    public GameObject Badget4;

    public GameObject Badget5;

    public bool bauen = false;

    void Start()
    {
        if (PlayerPrefs.HasKey("counter1"))
        {
            Counter1 = PlayerPrefs.GetInt("counter1");
        }
        else
        {
            Counter1 = 0;
            PlayerPrefs.SetInt("counter1", Counter1);
        }
    }

    public void EnterBuildMode()
    {
        inBuildMode = true;

    }

    void Update()
    {
        if(PlayerPrefs.GetInt("bauen") == 0)
        {
            bauen = false;
        }
        else
        {
            bauen = true;
        }

        if (inBuildMode && Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("counter1") == 0 )
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 5;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
            inBuildMode = false;
            Counter1 = PlayerPrefs.GetInt("counter1");
            Counter1++;
            PlayerPrefs.SetInt("counter1", Counter1);
            int money = PlayerPrefs.GetInt("money");
            money = money - 200;
            PlayerPrefs.SetInt("money", money);
        }

        if (PlayerPrefs.GetInt("counter1") == 0 && bauen == true)
        {
            Badget0.GetComponent<Image>().enabled = false;
            Badget1.GetComponent<Image>().enabled = true;
        }
        else if(PlayerPrefs.GetInt("counter1") >= 1 && bauen == true)
        {
            Badget1.GetComponent<Image>().enabled = false;
            Badget0.GetComponent<Image>().enabled = true;
        }
        if (PlayerPrefs.GetInt("counter2") == 0 && bauen == true)
        {
            Badget2.GetComponent<Image>().enabled = false;
            Badget3.GetComponent<Image>().enabled = true;
        }
        else if (PlayerPrefs.GetInt("counter2") >= 1 && bauen == true)
        {
            Badget3.GetComponent<Image>().enabled = false;
            Badget2.GetComponent<Image>().enabled = true;
        }
        if (PlayerPrefs.GetInt("counter3") == 0 && bauen == true)
        {
            Badget4.GetComponent<Image>().enabled = false;
            Badget5.GetComponent<Image>().enabled = true;
        }
        else if (PlayerPrefs.GetInt("counter3") >= 1 && bauen == true)
        {
            Badget5.GetComponent<Image>().enabled = false;
            Badget4.GetComponent<Image>().enabled = true;
        }
        if(bauen == false)
        {
            Badget0.GetComponent<Image>().enabled = false;
            Badget1.GetComponent<Image>().enabled = false;
            Badget2.GetComponent<Image>().enabled = false;
            Badget3.GetComponent<Image>().enabled = false;
            Badget4.GetComponent<Image>().enabled = false;
            Badget5.GetComponent<Image>().enabled = false;
        }

    }
}

