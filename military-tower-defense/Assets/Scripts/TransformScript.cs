using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public Transform childTransform;

    void Start()
    {
        childTransform.SetParent(transform);
    }
}
