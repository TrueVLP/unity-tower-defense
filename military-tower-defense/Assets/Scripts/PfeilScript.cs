using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PfeilScript : MonoBehaviour
    {
        public string targetTag = "Bloon";
        public float rotationSpeed = 5f;
        public float range = 10f;
        public GameObject projectilePrefab;
        public float fireRate = 1f;
        public Vector3 projectileOffset;

        private Transform target;
        private float fireTimer = 0f;

        void Update()
        {
            // Suche nach dem Ziel anhand des Tags
            if (target == null)
            {
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
            }

            // Spawnen von Raketen/Pfeilen
            fireTimer += Time.deltaTime;
            if (fireTimer >= fireRate)
            {
                fireTimer = 0f;
                Instantiate(projectilePrefab, transform.position + projectileOffset, transform.rotation);
            }
        }
    }
}