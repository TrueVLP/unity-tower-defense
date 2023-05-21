using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class DragAndDropObject : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 initialPosition;
    bool MouseDown = false;
    bool MouseUp = false;
    bool MouseDrag = false;
    private bool inBuildMode = false;
    int Counter1 = 0; 

    public GameObject ObjectToSpawn; 

    public void OnMouseDown()
    {
        MouseDown = true;
        /*
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            initialPosition = transform.position;
        }
        */
    }

    public void Ausführen()
    {
        if (MouseDown == true)
        {

            
                isDragging = true;
                initialPosition = transform.position;
            
        }
        if (MouseUp == true)
        {
            if (isDragging)
            {
                isDragging = false;

                Vector3 mousePos = Input.mousePosition;
                mousePos.z = 10;
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
                /*
                // Überprüfen, ob das Feld getroffen wurde
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Feld"))
                    {
                        // Das Objekt auf der Position des Feldes platzieren 
                        transform.position = hit.collider.transform.position;
                        Vector3 mousePos = Input.mousePosition;
                        mousePos.z = 10;
                        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                        Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
                    }
                    else
                    {
                        // Das Objekt zur ursprünglichen Position zurücksetzen
                        transform.position = initialPosition;
                    }
                }
                else
                {
                    // Das Objekt zur ursprünglichen Position zurücksetzen
                    transform.position = initialPosition;
                }
            
                */
            }
        }

        if (MouseDrag == true)
        {
            if (isDragging)
            {
                // Die Position des Objekts entsprechend der Mausposition aktualisieren
                Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
                Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = objPosition;
            }
        }
    }

     public void OnMouseUp()
    {
        MouseUp = true;
        /*

            {
                if (isDragging)
                {
                    isDragging = false;

                    // Überprüfen, ob das Feld getroffen wurde
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.CompareTag("Feld"))
                        {
                            // Das Objekt auf der Position des Feldes platzieren
                            transform.position = hit.collider.transform.position;
                        }
                        else
                        {
                            // Das Objekt zur ursprünglichen Position zurücksetzen
                            transform.position = initialPosition;
                        }
                    }
                    else
                    {
                        // Das Objekt zur ursprünglichen Position zurücksetzen
                        transform.position = initialPosition;
                    }

                }
        */
    }



   public void OnMouseDrag()
    {
        MouseDrag = true; 
        /*
                if (isDragging)
                {
                    // Die Position des Objekts entsprechend der Mausposition aktualisieren
                    Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
                    Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    transform.position = objPosition;
                }
            }
        }
        */
    }

    public void EnterBuildMode()
    {
        inBuildMode = true;

    }

    void Update()
    {
        if (inBuildMode && Input.GetMouseButtonDown(0) && Counter1 == 0 )
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ObjectToSpawn, worldPos, Quaternion.identity);
            inBuildMode = false;
            Counter1++; 
        }
    }
}

