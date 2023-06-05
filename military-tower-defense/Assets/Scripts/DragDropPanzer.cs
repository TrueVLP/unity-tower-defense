using System.Collections;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DragAndDropPanzer : MonoBehaviour
{
    private bool inBuildMode = false;

    public GameObject ObjectToSpawn;

    public GameObject ObjectToSpawn2;

    public bool bauen = false;

    public GameObject[] streets;

    public GameObject[] lakes;

    public UnityEngine.UI.Image NotEnoughMoney;

    public UnityEngine.UI.Image CantBuildHere;

    void Start()
    {
        // Find and enable all objects with the tag "street"
        streets = GameObject.FindGameObjectsWithTag("street");
        foreach (GameObject street in streets)
        {
            street.SetActive(false);
        }

        // Find and enable all objects with the tag "lake"
        lakes = GameObject.FindGameObjectsWithTag("lake");
        foreach (GameObject lake in lakes)
        {
            lake.SetActive(false);
        }
    }
    public void EnterBuildMode()
    {
        inBuildMode = true;

        PlayerPrefs.SetInt("speed", 0);

        foreach (GameObject street in streets)
        {
            street.SetActive(true);
        }

        foreach (GameObject lake in lakes)
        {
            lake.SetActive(true);
        }

        PlayerPrefs.SetInt("bp", 1);

    }

    void Update()
    {
        if (PlayerPrefs.GetInt("bauen") == 0)
        {
            bauen = false;
        }
        else
        {
            bauen = true;
        }

        if (inBuildMode && Input.GetMouseButtonDown(0))
        {
            // Check if the mouse pointer is colliding with an object with the specified tags
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && (hit.collider.tag == "lake" || Physics.Raycast(ray, out hit) && hit.collider.tag == "street"))
            {
                // The mouse pointer is colliding with an object with one of the specified tags
                // Do not build
                CantBuildHere.GetComponent<UnityEngine.UI.Image>().enabled = true;
                StartCoroutine(Delay(1f));

            }
            else
            {
                // The mouse pointer is not colliding with an object with one of the specified tags
                // Build
                Vector3 mousePos = Input.mousePosition;
                int money = PlayerPrefs.GetInt("money");
                money = money - 200;
                if (money >= 0)
                {
                    PlayerPrefs.SetInt("money", money);
                    mousePos.z = 5;
                    Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

                    if (PlayerPrefs.GetInt("p") == 0)
                    {
                        Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
                    }

                    if (PlayerPrefs.GetInt("p") == 1)
                    {
                        Instantiate(ObjectToSpawn2, worldPos, Quaternion.identity);
                    }
                    inBuildMode = false;
                    // Find and enable all objects with the tag "street"
                    GameObject[] streets = GameObject.FindGameObjectsWithTag("street");
                    foreach (GameObject street in streets)
                    {
                        street.SetActive(false);
                    }

                    // Find and enable all objects with the tag "lake"
                    GameObject[] lakes = GameObject.FindGameObjectsWithTag("lake");
                    foreach (GameObject lake in lakes)
                    {
                        lake.SetActive(false);
                    }
                }
                else
                {
                    NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = true;
                    StartCoroutine(Delay2(1f));
                }
            }
        }
        PlayerPrefs.SetInt("bp", 0);
    }

    IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);

        CantBuildHere.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }

    IEnumerator Delay2(float delay)
    {
        yield return new WaitForSeconds(delay);

        NotEnoughMoney.GetComponent<UnityEngine.UI.Image>().enabled = false;

    }
}
