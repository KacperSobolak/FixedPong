using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{

    public int speed = 20;

    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();

        Vector3 vector;

        if (Random.RandomRange(0, 2) == 0)
        {
            vector = new Vector3(1.0f * speed, 0f, Random.Range(-0.5f, 0.5f) * speed);
        }
        else
        {
            vector = new Vector3(-1.0f * speed,0f , Random.Range(-0.5f, 0.5f) * speed);

        }
        body.velocity = vector;

    }
}