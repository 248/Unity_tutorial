﻿using UnityEngine;
using System.Collections;

public class PlayerContlloer : MonoBehaviour
{

    public float speed = 10;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);
    }

}
