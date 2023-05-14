using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PfeilScript : MonoBehaviour
    {
        public float speed = 10f;
        public float lifetime = 5f;

        void Start()
        {
            // Destroy the projectile after its lifetime has passed
            Destroy(gameObject, lifetime);
        }

        void Update()
        {
            // Move the projectile forward
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}