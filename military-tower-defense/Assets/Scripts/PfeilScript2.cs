using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfeilScript2 : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 direction = new Vector3(transform.up.x, transform.up.y, 0);
        transform.position += direction * speed * Time.deltaTime;
    }

}