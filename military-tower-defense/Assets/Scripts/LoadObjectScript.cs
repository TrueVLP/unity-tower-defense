using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjectScript : MonoBehaviour
{

    public GameObject panzer;
    public GameObject hubschrauber;
    public GameObject schiff;
    public GameObject panzer2;

    void Start()
    {
        // Load all saved panzers
        int panzerCount = PlayerPrefs.GetInt("panzerCount", 0);
        for (int i = 0; i < panzerCount; i++)
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("panzerx" + i), PlayerPrefs.GetFloat("panzery" + i), PlayerPrefs.GetFloat("panzerz" + i));

            if(PlayerPrefs.GetInt("p") == 0)
            {
                Instantiate(panzer, position, Quaternion.identity);
            }
            
            if(PlayerPrefs.GetInt("p") == 1)
            {
                Instantiate(panzer2, position, Quaternion.identity);
            }
        }

        // Load all saved hubschraubers
        int hubschrauberCount = PlayerPrefs.GetInt("hubschrauberCount", 0);
        for (int i = 0; i < hubschrauberCount; i++)
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("hubschrauberx" + i), PlayerPrefs.GetFloat("hubschraubery" + i), PlayerPrefs.GetFloat("hubschrauberz" + i));
            Instantiate(hubschrauber, position, Quaternion.identity);
        }

        // Load all saved schiffs
        int schiffCount = PlayerPrefs.GetInt("schiffCount", 0);
        for (int i = 0; i < schiffCount; i++)
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("schiffx" + i), PlayerPrefs.GetFloat("schiffy" + i), PlayerPrefs.GetFloat("schiffz" + i));
            Instantiate(schiff, position, Quaternion.identity);
        }
    }

    void Update()
    {
        // Save all panzers
        GameObject[] panzers = GameObject.FindGameObjectsWithTag("panzer");
        PlayerPrefs.SetInt("panzerCount", panzers.Length);
        for (int i = 0; i < panzers.Length; i++)
        {
            Vector3 position = panzers[i].transform.position;
            PlayerPrefs.SetFloat("panzerx" + i, position.x);
            PlayerPrefs.SetFloat("panzery" + i, position.y);
            PlayerPrefs.SetFloat("panzerz" + i, position.z);
        }

        // Save all hubschraubers
        GameObject[] hubschraubers = GameObject.FindGameObjectsWithTag("hubschrauber");
        PlayerPrefs.SetInt("hubschrauberCount", hubschraubers.Length);
        for (int i = 0; i < hubschraubers.Length; i++)
        {
            Vector3 position = hubschraubers[i].transform.position;
            PlayerPrefs.SetFloat("hubschrauberx" + i, position.x);
            PlayerPrefs.SetFloat("hubschraubery" + i, position.y);
            PlayerPrefs.SetFloat("hubschrauberz" + i, position.z);
        }

        // Save all schiffs
        GameObject[] schiffs = GameObject.FindGameObjectsWithTag("schiff");
        PlayerPrefs.SetInt("schiffCount", schiffs.Length);
        for (int i = 0; i < schiffs.Length; i++)
        {
            Vector3 position = schiffs[i].transform.position;
            PlayerPrefs.SetFloat("schiffx" + i, position.x);
            PlayerPrefs.SetFloat("schiffy" + i, position.y);
            PlayerPrefs.SetFloat("schiffz" + i, position.z);
        }

    }
}
