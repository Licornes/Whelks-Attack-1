﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScriptMenu : MonoBehaviour
{

    float scrollSpeed = -0.05f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 20);
        transform.position = startPos + Vector2.right * newPos;
    }
}