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
    public int waveCount = 0;
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
        waveCount++;
        PlayerPrefs.SetInt("rounds", waveCount);

        for (int i = 0; i < enemiesPerWave; i++)
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
    }
}