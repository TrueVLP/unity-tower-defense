using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfMapScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        int hearts = PlayerPrefs.GetInt("hearts") - 5;
        PlayerPrefs.SetInt("hearts", hearts);
        
    }
}
