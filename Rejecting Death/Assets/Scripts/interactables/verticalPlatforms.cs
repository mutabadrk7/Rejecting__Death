﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalPlatforms : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;


    private void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            waitTime = 0.5f;
        }
            if (Input.GetKey(KeyCode.DownArrow))
        {
            if(waitTime >= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0.5f;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0f;
        }

    }
}
