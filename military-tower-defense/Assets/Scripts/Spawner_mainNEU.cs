using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner_mainNEU : MonoBehaviour
{
    //Objekte die, die Wellen und das Spawnen in der Main Methode kümmern
    public GameObject[] enemyPrefabs;
    public float spawnRadius = 5f;
    public float spawnInterval = 1f;
    public int enemiesPerWave = 15;
    public int waveCount = 1;
    public TextMeshProUGUI roundText;
    public Transform[] spawnPoints;
    public int randomIndex = 0;


    //holt sich gespeicherte Runden und startet die Wellen
    void Start()
    {
        if (PlayerPrefs.HasKey("rounds"))
        {
            waveCount = PlayerPrefs.GetInt("rounds");
        }
        else
        {
            waveCount = 1;
            PlayerPrefs.SetInt("rounds", waveCount);
        }

        PlayerPrefs.SetInt("speed", 0);
        StartCoroutine(SpawnWave());
    }

    //Verhalten der Wellen
    private IEnumerator SpawnWave()
    {
        while (PlayerPrefs.GetInt("speed") == 0)
        {
            yield return null;
        }

    GameObject enemyPrefab2 = enemyPrefabs[8];

        for (int i = 1; i < enemiesPerWave; i++)
        {
            if (PlayerPrefs.GetInt("speed") != 0)
            {
                if (i == 1)
                {
                    Vector3 randomSpawnOffset2 = Random.insideUnitSphere * spawnRadius;
                    Vector3 spawnPosition2 = spawnPoints[0].position + randomSpawnOffset2;
                    Quaternion spawnRotation2 = Quaternion.identity;
                    Instantiate(enemyPrefab2, spawnPosition2, spawnRotation2);
                }
                if(waveCount == 1)
                {
                    randomIndex = Random.Range(0, (enemyPrefabs.Length - 3));
                }
                else if (waveCount == 2)
                {
                    randomIndex = Random.Range(0, (enemyPrefabs.Length - 3));
                }
                else if (waveCount == 3)
                {
                    randomIndex = Random.Range(0, (enemyPrefabs.Length - 2));
                }
                else if (waveCount == 4)
                {
                    randomIndex = Random.Range(4, (enemyPrefabs.Length - 2));
                }
                else
                {
                    randomIndex = Random.Range(7, (enemyPrefabs.Length));
                }
               
                GameObject enemyPrefab = enemyPrefabs[randomIndex];

                int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length);
                Transform selectedSpawnPoint = spawnPoints[randomSpawnPointIndex];

                Vector3 randomSpawnOffset = Random.insideUnitSphere * spawnRadius;
                Vector3 spawnPosition = selectedSpawnPoint.position + randomSpawnOffset;
                Quaternion spawnRotation = Quaternion.identity;
                GameObject enemy = Instantiate(enemyPrefab, spawnPosition, spawnRotation);
            }
            yield return new WaitForSeconds(spawnInterval);
        }

        while (GameObject.FindGameObjectsWithTag("bloon").Length > 0)
        {
            yield return null;
        }
        PlayerPrefs.SetInt("speed", 0);

        if (waveCount >= 5)
        {
            SceneManager.LoadScene(4);
        }
        if (waveCount < 5)
        {
            StartCoroutine(SpawnWave());
        }

        waveCount++;

        enemiesPerWave = enemiesPerWave + 3;

        if (waveCount == 5)
        {
            enemiesPerWave = 35;
            spawnInterval = 0.15f;
        }
        else if (waveCount >= 3)
        {

            spawnInterval = 0.5f;
        }

        PlayerPrefs.SetInt("rounds", waveCount);
        
    }

}