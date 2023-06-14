using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PanzerObject : MonoBehaviour
{
    //Script zum bedienen der Panzer, Helikopter und Schiffe

    public string targetTag = "bloon";
    public float rotationSpeed = 5f;
    public float range = 5f;
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    public float spawnRate = 1f;
    private float timer = 0f;

    private Transform target;

    void Update()
    {
        float adjustedRotationSpeed = rotationSpeed * PlayerPrefs.GetInt("speed");
        float adjustedSpawnRate = (float)(spawnRate * (PlayerPrefs.GetInt("speed")/4.5));

        if (target == null || Vector3.Distance(transform.position, target.position) > range)
        {
            target = null;
            GameObject[] targetObjects = GameObject.FindGameObjectsWithTag(targetTag);
            float closestDistance = Mathf.Infinity;
            foreach (GameObject targetObject in targetObjects)
            {
                float distance = Vector3.Distance(transform.position, targetObject.transform.position);
                if (distance < closestDistance && distance <= range)
                {
                    closestDistance = distance;
                    target = targetObject.transform;
                }
            }
        }

        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            if (direction.magnitude <= range)
            {
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
                Quaternion lookRotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * adjustedRotationSpeed);
            }

            timer += Time.deltaTime;
            if (timer >= adjustedSpawnRate && PlayerPrefs.GetInt("speed") >= 1 && (direction.magnitude <= range))
            {
                Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
                timer = 0f;
            }
        }
    }


}


