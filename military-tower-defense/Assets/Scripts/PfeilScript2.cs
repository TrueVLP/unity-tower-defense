using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfeilScript2 : MonoBehaviour
{
    public float speed = 10f;

    public int moneyability;

    void Start()
    {
        PlayerPrefs.SetInt("ability2", 0);
    }

    void Update()
    {
        Vector3 direction = new Vector3(transform.up.x, transform.up.y, 0);
        transform.position += direction * speed * Time.deltaTime;
    }


    void OnCollisionEnter(Collision collision)
    {
        int money = PlayerPrefs.GetInt("money");
        if (PlayerPrefs.GetInt("ability2") == 1)
        {
            money = money + 30;
        }
        else
        {
            money = money + 20;
        }

        PlayerPrefs.SetInt("money", money);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}