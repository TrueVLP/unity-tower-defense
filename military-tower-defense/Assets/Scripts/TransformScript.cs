using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public Transform childTransform;

    void Start()
    {
        // Setze das Transform-Objekt als Kind des GameObjects
        childTransform.SetParent(transform);
    }
}
