using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfeilScript2 : MonoBehaviour
{
    public float speed = 10f;

    public int moneyability;

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
            money = money + 15;
        }
        else
        {
            money = money + 10;
        }

        PlayerPrefs.SetInt("money", money);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}