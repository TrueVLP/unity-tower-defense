using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spawner_main : MonoBehaviour
{
    public GameObject[] bloons; // Array of Bloon prefabs
    public int round = 1; // Current round
    public float spawnDelay = 1f; // Time between spawns
    private Queue<GameObject> bloonsToSpawn; // Queue of Bloons to spawn this round
    private float spawnTimer = 0f; // Timer for spawning Bloons
    public TextMeshProUGUI roundText;
    public TextMeshProUGUI heartText;
    public int hearts = 100;

    void Start()
    {
        bloonsToSpawn = new Queue<GameObject>();
        SetBloonsToSpawn();
    }

    void Update()
    {
        // Check if all Bloons have been spawned for this round
        if (bloonsToSpawn.Count == 0)
        {
            // Check if there are no more Bloons on the map
            if (GameObject.FindGameObjectsWithTag("Bloon").Length == 0)
            {
                // Increment round and set Bloons to spawn
                round++;
                SetBloonsToSpawn();
            }
        }
        else
        {
            // Increment spawn timer
            spawnTimer += Time.deltaTime;

            // Check if it's time to spawn a Bloon
            if (spawnTimer >= spawnDelay)
            {
                // Spawn Bloon and remove it from the queue
                Instantiate(bloonsToSpawn.Dequeue(), transform.position, Quaternion.identity);
                spawnTimer = 0f;
            }
        }

        // Update round text
        roundText.text = "Round: " + round;

        heartText.text = "Lives: " + hearts;
    }

    void SetBloonsToSpawn()
    {
        // Clear the queue
        bloonsToSpawn.Clear();

        // Set Bloons to spawn based on the current round
        if (round == 1)
        {
            bloonsToSpawn.Enqueue(bloons[3]);
            bloonsToSpawn.Enqueue(bloons[4]);
        }
        else if (round == 2)
        {
            bloonsToSpawn.Enqueue(bloons[3]);
            bloonsToSpawn.Enqueue(bloons[4]);
            // ...
        }
        // ...
    }
}
