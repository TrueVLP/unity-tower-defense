using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Menu : MonoBehaviour
{
    public GameObject objectToSpawn1; 
    public GameObject objectToSpawn2; 
    public GameObject objectToSpawn3; 
    public GameObject objectToSpawn4; 
    public GameObject objectToSpawn5; 
    public GameObject objectToSpawn6; 
    public GameObject objectToSpawn7; 
    public GameObject objectToSpawn8; 

    public GameObject objectToSpawn; // Das zu spawnende GameObject



    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4; 
    public Transform spawnPoint5; 

    public Transform spawnPoint; // Der Spawnpunkt
    public float minSpawnTime = 1.0f; // Minimale Zeit zwischen zwei Spawns
    public float maxSpawnTime = 5.0f; // Maximale Zeit zwischen zwei Spawns

    //Spawnt die Objekte im Hauptmenü
    void Start()
    {
        StartCoroutine(SpawnObjectsAtRandomTimes());
    }

    //Schleife zum spawnen der Ballone
    IEnumerator SpawnObjectsAtRandomTimes()
    {
        while (true)
        {
            int randomNumber = Random.Range(1, 9);

            int randomNumber2 = Random.Range(1, 6);

            if (randomNumber == 1 ) 
            {
                objectToSpawn = objectToSpawn1;
            }
            if (randomNumber == 2)
            {
                objectToSpawn = objectToSpawn2;
            }
            if (randomNumber == 3)
            {
                objectToSpawn = objectToSpawn3;
            }
            if (randomNumber == 4)
            {
                objectToSpawn = objectToSpawn4;
            }
            if (randomNumber == 5)
            {
                objectToSpawn = objectToSpawn5;
            }
            if (randomNumber == 6)
            {
                objectToSpawn = objectToSpawn6;
            }
            if (randomNumber == 7)
            {
                objectToSpawn = objectToSpawn7;
            }
            if (randomNumber == 8)
            {
                objectToSpawn = objectToSpawn8;
            }
            if (randomNumber2 == 1)
            {
                spawnPoint = spawnPoint1;
            }
            if (randomNumber2 == 2)
            {
                spawnPoint = spawnPoint2;
            }
            if (randomNumber2 == 3)
            {
                spawnPoint = spawnPoint3;
            }
            if (randomNumber2 == 4)
            {
                spawnPoint = spawnPoint4;
            }
            if (randomNumber2 == 5)
            {
                spawnPoint = spawnPoint5;
            }
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }
}
