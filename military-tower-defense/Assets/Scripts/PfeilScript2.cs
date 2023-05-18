using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfeilScript2 : MonoBehaviour
{
    public float speed = 10000f;
    public GameObject objectToMove;

    void Update()
    {
        Vector3 direction = new Vector3(objectToMove.transform.forward.x, objectToMove.transform.forward.y, 0f);
        objectToMove.transform.position += direction * speed * Time.deltaTime;
    }
}