using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropSchiff : MonoBehaviour
{
    private bool inBuildMode = false;

    private int Counter1 = 0;

    public GameObject ObjectToSpawn;

    public void EnterBuildMode()
    {
        inBuildMode = true;

    }

    void Update()
    {
        if (inBuildMode && Input.GetMouseButtonDown(0) && Counter1 == 0)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 5;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
            inBuildMode = false;
            Counter1++;
        }
    }
}