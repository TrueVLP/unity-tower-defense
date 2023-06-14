using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfeilScript2 : MonoBehaviour
{

    //Script zum Steuern des Projektiles
    public float speed = 10f;
    public int moneyability;

    public WaypointController2k1 waypointController2k1;
    public WaypointControllerBunt waypointControllerBunt;
    public WaypointController2k2 waypointController2k2;

    public int hearts;

    public float maxDistance = 5f;
    private float distanceTraveled = 0f;

    void Update()
    {
        Vector3 direction = new Vector3(transform.up.x, transform.up.y, 0);
        transform.position += direction * speed * Time.deltaTime;
        distanceTraveled += speed * Time.deltaTime;
        if (distanceTraveled >= maxDistance)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bloon"))
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

            waypointController2k1 = collision.gameObject.GetComponent<WaypointController2k1>();
            waypointControllerBunt = collision.gameObject.GetComponent<WaypointControllerBunt>();
            waypointController2k2 = collision.gameObject.GetComponent<WaypointController2k2>();

            if (waypointController2k1 != null)
            {
                Destroy(gameObject);
                waypointController2k1.hearts -= 1;
                if (waypointController2k1.hearts == 0)
                {
                    Destroy(collision.gameObject);
                }
            }
            else if (waypointControllerBunt != null)
            {
                Destroy(gameObject);
                waypointControllerBunt.hearts -= 1;
                if (waypointControllerBunt.hearts == 0)
                {
                    Destroy(collision.gameObject);
                }
            }
            else if (waypointController2k2 != null)
            {
                Destroy(gameObject);
                waypointController2k2.hearts -= 1;
                if (waypointController2k2.hearts == 0)
                {
                    Destroy(collision.gameObject);
                }
            }
            else
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}
