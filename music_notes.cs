﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_notes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 4 * Time.deltaTime);

        if(transform.position.x >= 9.39)
        {
            transform.position = new Vector2(-7.28f, -2.81f);
        }
    }
}
