﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler.cs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");

    GetComponent<Rigidbody2D>().velcocity = new Vector2(horiz, 0.0f);
    }
}
