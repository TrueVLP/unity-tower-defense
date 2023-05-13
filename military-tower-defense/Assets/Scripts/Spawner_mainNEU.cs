using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner_mainNEU : MonoBehaviour, ISaveable
{
    public GameObject[] enemyPrefabs; // Array mit den zu spawnenden Gegner-Objekten
    public float spawnRadius = 5f; // Radius innerhalb dessen die Gegner spawnen sollen
    public float spawnInterval = 1f; // Abstand zwischen den einzelnen Spawn-Wellen
    public int enemiesPerWave = 5; // Anzahl der Gegner pro Welle
    public int waveCount = 0; // Zähler für die Anzahl der Wellen
    public Transform spawnPoint; // Spawn-Punkt, an dem die Gegner spawnen sollen
    public TextMeshProUGUI roundText;
    public TextMeshProUGUI heartText;
    public int hearts = 100;

    private void Start()
    {
        StartCoroutine(SpawnWave()); // Startet die Coroutine für das Spawnen der Wellen
    }

    private IEnumerator SpawnWave()
    {
        waveCount++; // Erhöht den Wellenzähler

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

            // Update round text
            roundText.text = "Round: " + waveCount;

            heartText.text = "Lives: " + hearts;

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Welle", waveCount);
        PlayerPrefs.SetInt("Health", hearts);

    }
}
