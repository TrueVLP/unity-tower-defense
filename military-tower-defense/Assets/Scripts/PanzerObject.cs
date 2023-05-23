using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PanzerObject : MonoBehaviour
{

    public string targetTag = "bloon";
    public float rotationSpeed = 5f;
    public float range;
    public GameObject projectilePrefab;
    public Transform spawnPoint;
    public float spawnRate = 1f;
    private float timer = 0f;
    public bool rangeAbility = false;

    private Transform target;

    private void Start()
    {
        PlayerPrefs.SetInt("ability3", 5);
        
    }
    void Update()
    {
        range = PlayerPrefs.GetInt("ability3");

        if (target == null || Vector3.Distance(transform.position, target.position) > range)
        {
            target = null;
            GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
            if (targetObject != null)
            {
                target = targetObject.transform;
            }
        }


        // Orientierung des Panzers zum Ziel
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            if (direction.magnitude <= range)
            {
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
                Quaternion lookRotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
            }

            timer += Time.deltaTime;
            if (timer >= spawnRate && PlayerPrefs.GetInt("speed") > 1 && (direction.magnitude <= range))
            {
                Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
                timer = 0f;

            }
        }

        if (rangeAbility)
        {
            range = 2f;
        }
    }

}


