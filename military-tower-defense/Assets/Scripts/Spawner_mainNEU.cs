using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner_mainNEU : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array mit den zu spawnenden Gegner-Objekten
    public float spawnRadius = 5f; // Radius innerhalb dessen die Gegner spawnen sollen
    public float spawnInterval = 1f; // Abstand zwischen den einzelnen Spawn-Wellen
    public int enemiesPerWave = 5; // Anzahl der Gegner pro Welle
    public int waveCount = 0; // Zähler für die Anzahl der Wellen
    public Transform spawnPoint; // Spawn-Punkt, an dem die Gegner spawnen sollen
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
        StartCoroutine(SpawnWave()); // Startet die Coroutine für das Spawnen der Wellen
    }

    private IEnumerator SpawnWave()
    {
        waveCount++;
        PlayerPrefs.SetInt("rounds", waveCount);

        for (int i = 0; i < enemiesPerWave; i++)
        {
            // Zufälligen Gegner auswählen
            int randomIndex = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyPrefab = enemyPrefabs[randomIndex];

            // Gegner an Spawn-Punkt spawnen
            Vector3 randomSpawnOffset = Random.insideUnitSphere * spawnRadius;
            Vector3 spawnPosition = spawnPoint.position + randomSpawnOffset;
            Quaternion spawnRotation = Quaternion.identity;
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnInterval);
        }
        if (waveCount >= 5)
        {
            SceneManager.LoadScene(4);
        }
        if (waveCount < 5) // Überprüft, ob die aktuelle Welle die letzte ist
        {
            StartCoroutine(SpawnWave()); // Startet die Coroutine erneut für das Spawnen der nächsten Welle
        }
    }
}