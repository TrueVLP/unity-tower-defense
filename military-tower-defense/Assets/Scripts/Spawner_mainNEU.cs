using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner_mainNEU : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnRadius = 5f;
    public float spawnInterval = 1f;
    public int enemiesPerWave = 5;
    public int waveCount = 1;
    public Transform spawnPoint;
    public TextMeshProUGUI roundText;
   
    void Start()
    {
        if (PlayerPrefs.HasKey("rounds"))
        {
            waveCount = PlayerPrefs.GetInt("rounds");
        }
        else
        {
            waveCount = 0;
            PlayerPrefs.SetInt("money", waveCount);
        }
        StartCoroutine(SpawnWave());
    }

    private IEnumerator SpawnWave()
    {
        PlayerPrefs.SetInt("speed", 0);

        GameObject enemyPrefab2 = enemyPrefabs[8];

        Vector3 randomSpawnOffset2 = Random.insideUnitSphere * spawnRadius;
        Vector3 spawnPosition2 = spawnPoint.position + randomSpawnOffset2;
        Quaternion spawnRotation2 = Quaternion.identity;
        Instantiate(enemyPrefab2, spawnPosition2, spawnRotation2);

        for (int i = 1; i < enemiesPerWave; i++)
        {
            if (PlayerPrefs.GetInt("speed") != 0)
            {
                int randomIndex = Random.Range(0, enemyPrefabs.Length);
                GameObject enemyPrefab = enemyPrefabs[randomIndex];

                Vector3 randomSpawnOffset = Random.insideUnitSphere * spawnRadius;
                Vector3 spawnPosition = spawnPoint.position + randomSpawnOffset;
                Quaternion spawnRotation = Quaternion.identity;
                GameObject enemy = Instantiate(enemyPrefab, spawnPosition, spawnRotation);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
        if (waveCount >= 5)
        {
            SceneManager.LoadScene(4);
        }
        if (waveCount < 5)
        {
            StartCoroutine(SpawnWave());
        }

        waveCount++;

        PlayerPrefs.SetInt("rounds", waveCount);

    }
}