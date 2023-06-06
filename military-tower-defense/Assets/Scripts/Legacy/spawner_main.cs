using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spawner_main : MonoBehaviour
{
    public GameObject[] bloons;
    public int round = 1;
    public float spawnDelay = 1f; 
    private Queue<GameObject> bloonsToSpawn; 
    private float spawnTimer = 0f; 
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
        if (bloonsToSpawn.Count == 0)
        {
            if (GameObject.FindGameObjectsWithTag("Bloon").Length == 0)
            {
                round++;
                SetBloonsToSpawn();
            }
        }
        else
        {
            spawnTimer += Time.deltaTime;

            if (spawnTimer >= spawnDelay)
            {
                Instantiate(bloonsToSpawn.Dequeue(), transform.position, Quaternion.identity);
                spawnTimer = 0f;
            }
        }

        roundText.text = "Round: " + round;

        heartText.text = "Lives: " + hearts;
    }

    void SetBloonsToSpawn()
    {
        bloonsToSpawn.Clear();

        if (round == 1)
        {
            bloonsToSpawn.Enqueue(bloons[3]);
            bloonsToSpawn.Enqueue(bloons[4]);
        }
        else if (round == 2)
        {
            bloonsToSpawn.Enqueue(bloons[3]);
            bloonsToSpawn.Enqueue(bloons[4]);
        }
    }
}
