using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjectScript : MonoBehaviour
{
    public GameObject panzer;
    public GameObject hubschrauber;
    public GameObject schiff;

    void Start()
    {

        if (PlayerPrefs.HasKey("panzerx"))
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("panzerx"), PlayerPrefs.GetFloat("panzery"), PlayerPrefs.GetFloat("panzerz"));
            Instantiate(panzer, position, Quaternion.identity);
        }

        if (PlayerPrefs.HasKey("hubschrauberx"))
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("hubschrauberx"), PlayerPrefs.GetFloat("hubschraubery"), PlayerPrefs.GetFloat("hubschrauberz"));
            Instantiate(hubschrauber, position, Quaternion.identity);
        }

        if (PlayerPrefs.HasKey("schiffx"))
        {
            Vector3 position = new Vector3(PlayerPrefs.GetFloat("schiffx"), PlayerPrefs.GetFloat("schiffy"), PlayerPrefs.GetFloat("schiffz"));
            Instantiate(schiff, position, Quaternion.identity);
        }

    }


    void Update()
    {
        if(PlayerPrefs.GetInt("counter1") >= 1)
        {

            GameObject panzer = GameObject.FindWithTag("panzer");
            Vector3 position = panzer.transform.position;

            PlayerPrefs.SetFloat("panzerx", position.x);
            PlayerPrefs.SetFloat("panzery", position.y);
            PlayerPrefs.SetFloat("panzerz", position.z);

        }
        if (PlayerPrefs.GetInt("counter2") >= 1)
        {

            GameObject hubschrauber = GameObject.FindWithTag("hubschrauber");
            Vector3 position = hubschrauber.transform.position;

            PlayerPrefs.SetFloat("hubschrauberx", position.x);
            PlayerPrefs.SetFloat("hubschraubery", position.y);
            PlayerPrefs.SetFloat("hubschrauberz", position.z);

        }
        if (PlayerPrefs.GetInt("counter3") >= 1)
        {

            GameObject schiff = GameObject.FindWithTag("schiff");
            Vector3 position = schiff.transform.position;

            PlayerPrefs.SetFloat("schiffx", position.x);
            PlayerPrefs.SetFloat("schiffy", position.y);
            PlayerPrefs.SetFloat("schiffz", position.z);

        }

    }
}
