using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class PfeilScript : MonoBehaviour
    {
        public string objectTag = "pfeil";
        public float speed = 5f;

        private GameObject[] objectsToMove;

        void Start()
        {
            
        }

        void Update()
        {
            objectsToMove = GameObject.FindGameObjectsWithTag(objectTag);

            foreach (GameObject objectToMove in objectsToMove)
            {
                Vector3 direction = new Vector3(objectToMove.transform.forward.x, objectToMove.transform.forward.y, 0f);
                objectToMove.transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}